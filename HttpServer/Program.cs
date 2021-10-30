﻿using System;
using Grapevine;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace HttpServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Run();
            Console.WriteLine("Built");
        }

        public readonly static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public static void Run()
        {
            if (File.Exists(configPath))
            {
            var server = RestServerBuilder.UseDefaults().Build();
            server.Prefixes.Clear();
            server.Prefixes.Add("http://+:8888/");
            var getResepRoute = new Route(async (context) =>
            {
                context.Response.StatusCode = HttpStatusCode.Ok;
                context.Response.ContentType = ContentType.Json;
                await context.Response.SendResponseAsync(File.ReadAllText(configPath));
            }, "Get", "/resep");
            var setResepRoute = new Route(async(context) =>
            {
                Stream stream = context.Request.InputStream;
                Resep resep = await JsonSerializer.DeserializeAsync<Resep>(stream);
                List<Resep> listInConfigFile = JsonSerializer.Deserialize<List<Resep>>(File.ReadAllText(configPath));
                listInConfigFile.Add(resep);
                File.WriteAllText(configPath, JsonSerializer.Serialize(listInConfigFile));
                await context.Response.SendResponseAsync(HttpStatusCode.Accepted);
            },"Post","/resep");
            server.Router.Register(setResepRoute);
            server.Router.Register(getResepRoute);
            server.Run();
            }
            else
            {
                List<Resep> emptyList = new List<Resep>();
                File.WriteAllText(configPath, JsonSerializer.Serialize(emptyList));
                Run();
            }
        }
    }
}
