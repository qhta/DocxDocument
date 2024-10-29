public static class Program
{

  public static void Main(string[] args)
  {
    String[] dirs = Directory.GetDirectories(@"d:\VS\Projects\DocumentFormat.OpenXml\");
    foreach (String dir in dirs)
    {
      if (Path.GetFileName(dir).StartsWith("DocumentFormat"))
        ProcessDirectory(dir);
    }
  }
  private static bool ProcessDirectory(String dir)
  {
    var done = false;
    //Console.WriteLine(dir);
    String[] files = Directory.GetFiles(dir);
    foreach (String file in files)
    {
      var prefix = GetPrefix(file);
      if (prefix != null)
      {
        var k = dir.IndexOf("DocumentFormat");
        if (k != -1)
        {
          var ns = dir.Substring(k);
          k = ns.IndexOf("DocumentFormat",1);
          if (k != -1)
          {
            ns = ns.Substring(k);
            Console.WriteLine(prefix + ": " + ns);
            done = true;
          }
        }
        break;
      }
    }
    return done;
  }

  private static string? GetPrefix(String file)
  {
    //Console.WriteLine(file);
    using (var reader = new StreamReader(file))
    {
      var lines = reader.ReadToEnd().Split('\n');
      var attr = GetSchemaAttr(lines);
      if (attr != null)
      {
        var k = attr.IndexOf(':');
        if (k != -1)
        {
          var prefix = attr.Substring(0, k).Trim();
          return prefix;
        }
      }
    }
    return null;
  }

  private static string? GetSchemaAttr(string[] lines)
  {
    for (int i = 0; i < lines.Length; i++)
    {
      var line = lines[i].Trim();
      var k = line.IndexOf("SchemaAttr");
      if (k != -1)
      {
        //Console.WriteLine(line);
        var arg = line.Substring(k + "SchemaAttr".Length).Trim();
        k = arg.IndexOf('(');
        if (k != -1)
        {
          arg = arg.Substring(k + 1).Trim();
          k = arg.IndexOf(')');
          if (k != -1)
          {
            arg = arg.Substring(0, k);
            k = arg.IndexOf('"');
            if (k != -1)
            {
              arg = arg.Substring(k + 1).Trim();
              k = arg.LastIndexOf('"');
              if (k != -1)
              {
                arg = arg.Substring(0, k).Trim();
                //Console.WriteLine(arg);
                return arg;
              }
            }
          }
        }
        break;
      }
    }
    return null;
  }

  private static void ProcessFile(String file)
  {
    //Console.WriteLine(file);
    using (var reader = new StreamReader(file))
    {
      var text = reader.ReadToEnd().Split('\n');
      for (int i = 0; i < text.Length; i++)
      {
        var line = text[i].Trim();
        if (line.StartsWith("public"))
        {
          //Console.WriteLine(line);
          var k = line.IndexOf(':');
          if (k != -1)
          {
            var baseType = line.Substring(k + 1).TrimStart();
            var thisType = line.Substring(0, k).TrimEnd();
            k = thisType.LastIndexOf(' ');
            if (k != -1)
              thisType = thisType.Substring(k + 1);

            //Console.WriteLine(thisType + ": " + baseType);
          }
          break;
        }
      }
    }
  }
}
