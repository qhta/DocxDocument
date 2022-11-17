// See https://aka.ms/new-console-template for more information

using System.Reflection;
using ModelGen;

var filepath = Assembly.GetExecutingAssembly().Location;
var index = filepath.IndexOf(@"\bin");
if (index > 0)
  filepath = filepath.Substring(0, index);
index = filepath.LastIndexOf(@"\");
if (index > 0)
  filepath = filepath.Substring(0, index);
filepath = Path.Combine(filepath, "GeneratedModel");
var generator = new Generator("GeneratedModel", filepath);
generator.GenLibrary(typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly);
