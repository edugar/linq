﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class clsQueries
    {
        private List<Game> juegosPS = new List<Game>();
        private List<Game> juegosXBOX = new List<Game>();

        public clsQueries() 
        {
            string relativePath = "json/videojuegosPS.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                this.juegosPS = JsonSerializer.Deserialize<List<Game>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }

            using(StreamReader reader = new StreamReader("json/videojuegosXBOX.json"))
            {
                string json = reader.ReadToEnd();
                this.juegosXBOX = JsonSerializer.Deserialize<List<Game>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public IEnumerable<Game> JuegosPS()
        {
            return juegosPS;
        }



        //WHERE

        //CONTAINS

        //ALL

        //ANY

        //ORDER BY

        //ORDER BY DESCENDING

        //TAKE

        //SKIP

        //SELECT

        //COUNT

        //LONG COUNT

        //MIN

        //MAX

        //MIN BY

        //MAX BY

        //SUM

        //AGERGGATE

        //AVERAGE

        //GROUP BY

        //LOOKUP

        //JOIN

        //LEFT JOIN

        //RIGTH JOIN
















    }
}