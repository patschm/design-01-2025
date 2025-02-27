﻿using AbstractFactory.ArtDeco;
using AbstractFactory.Modern;

namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        var modern = new ModernFactory();
        var table = modern.CreateTable();
        table.BuildTable();
        modern.CreateSofa().BuildSofa();
        modern.CreateChair().BuildChair();

        var artdeco = new ArtDecoFactory();
        artdeco.CreateTable().BuildTable();
        artdeco.CreateSofa().BuildSofa();
        artdeco.CreateChair().BuildChair();
    }
}