using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Xml.Linq;

using Microsoft.EntityFrameworkCore;

using NuGet.Configuration;

using OpenXmlDatabase;

using OpenXmlModels = OpenXmlDatabase.Models;
using Type = System.Type;

namespace ScanOpenXmlTypes;

public partial class OpenXmlScanner : IDisposable, IAsyncDisposable
{

  XDocument OpenXmlDocumentation = null!;
  XDocument OpenXmlFrameworkDocumentation = null!;
  private int missingTypeDescriptionsCount;
  private int modifiedTypeDescriptionsCount;



  public void ScanDocumentationFile()
  {
    OpenXmlDocumentation = OpenXmlDocumentationFile(OpenXmlAssembly);
    OpenXmlFrameworkDocumentation = OpenXmlDocumentationFile(OpenXmlFrameworkAssembly);
    ScanTypeDescriptions();
  }

  private XDocument OpenXmlDocumentationFile(Assembly assembly)
  {
    var assemblyPath = assembly.Location;

    // Construct the path to the XML documentation file
    var xmlFilePath = Path.ChangeExtension(assemblyPath, ".xml");

    if (!File.Exists(xmlFilePath))
    {
      // If the XML documentation file does not exist, search for it in the nuget packages folder
      xmlFilePath = FindXmlDocumentationFile(assembly);
      if (xmlFilePath == null)
      {
        throw new InvalidOperationException($"{assembly.GetName().Name}.xml documentation file not found.");
      }
    }
    if (File.Exists(xmlFilePath))
    {
      // Read the XML documentation file
      var xDocument = XDocument.Load(xmlFilePath);
      return xDocument;
    }
    else
    {
      throw new InvalidOperationException($"{assembly.GetName().Name}.xml documentation file not found.");
    }
  }

  private string? FindXmlDocumentationFile(Assembly assembly)
  {
    var packageName = assembly.GetName().Name!;
    var settings = Settings.LoadDefaultSettings(null);
    var globalPackagesFolder = SettingsUtility.GetGlobalPackagesFolder(settings);

    var packageFolder = Path.Combine(globalPackagesFolder, packageName);
    if (Directory.Exists(packageFolder))
    {
      var versionFolders = Directory.GetDirectories(packageFolder).OrderByDescending(d => d);
      foreach (var versionFolder in versionFolders)
      {
        var targetFramework = GetTargetFramework(assembly);
        var xmlFilePath = Path.Combine(versionFolder, "lib", targetFramework, $"{packageName}.xml");
        if (File.Exists(xmlFilePath))
        {
          return xmlFilePath;
        }
      }
    }
    return null;
  }

  private string GetTargetFramework(Assembly assembly)
  {
    var targetFrameworkAttribute = assembly.GetCustomAttribute<TargetFrameworkAttribute>();
    if (targetFrameworkAttribute != null)
    {
      var frameworkName = new FrameworkName(targetFrameworkAttribute.FrameworkName);
      return frameworkName.Identifier switch
      {
        ".NETFramework" => $"net{frameworkName.Version.Major}{frameworkName.Version.Minor}",
        ".NETCoreApp" => $"net{frameworkName.Version.Major}.{frameworkName.Version.Minor}",
        ".NETStandard" => $"netstandard{frameworkName.Version.Major}.{frameworkName.Version.Minor}",
        _ => "Unknown"
      };
    }
    return "Unknown";
  }


  public void ScanTypeDescriptions()
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Scanning type descriptions");
    foreach (var type in OpenXmlDatabase.Types.Where(t => t.IsGeneric == false && t.IsNested == false)
               .Include(t => t.Namespace))
    {
      foundTypesCount++;
      if (VerboseLevel == 1)
        if (foundTypesCount % 100 == 0)
          Console.Write(".");
      TryAddTypeDescription(type);
    }
    if (VerboseLevel > 0)
    {
      Console.WriteLine();
      Console.WriteLine($"Modified type descriptions {modifiedTypeDescriptionsCount}");
      Console.WriteLine($"Missing type descriptions {missingTypeDescriptionsCount}");
    }
  }

  //private List<string> OfficeVersions = new List<string>();// { "Office 2007", "Office 2010", "Office 2013", "Office 2016", "Office 2019" };
  private void TryAddTypeDescription(OpenXmlModels.Type type)
  {
    if (VerboseLevel > 0)
      Console.Write($"Type {GetFullName(type)} description");
    var typeTag = $"T:{type.Namespace?.Name}.{type.Name}";
    var xDocument = type.AssemblyId == 1 ? OpenXmlDocumentation : OpenXmlFrameworkDocumentation;
    var typeElement = xDocument.Descendants("member")
      .FirstOrDefault(e => e.Attribute("name")?.Value == typeTag);
    if (typeElement != null)
    {
      var summaryElement = typeElement.Element("summary");
      if (summaryElement != null)
      {
        string? description = null;
        byte? officeVersion = null;
        string? tag = null;
        foreach (var paraElement in summaryElement.Descendants("para"))
        {

          var text = paraElement.Value.Trim();
          if (text.StartsWith("This class is available"))
          {
            if (text.Contains("Office 2007"))
              officeVersion = 1;
            else if (text.Contains("Office 2010"))
              officeVersion = 2;
            else if (text.Contains("Office 2013"))
              officeVersion = 3;
            else if (text.Contains("Office 2016"))
              officeVersion = 4;
            else if (text.Contains("Office 2019"))
              officeVersion = 5;
            else if (text.Contains("Office 2021"))
              officeVersion = 6;
            else if (text.Contains("Microsoft365"))
              officeVersion = 255;
            else
            {
              throw new InvalidOperationException($"Unknown Office version {text}");
            }
            //Console.WriteLine($"{type} Office version = {officeVersion}");
          }
          else if (text.StartsWith("When the object is serialized out as xml"))
          {
            if (text.EndsWith("."))
              text = text.Substring(0, text.Length - 1);
            var k = text.LastIndexOf(' ');
            if (k != -1)
              tag = text.Substring(k + 1);
            if (tag == ":")
              tag = null;
            //Console.WriteLine($"{type} tag = {tag}");
          }
          else
          {
            if (description != null)
              description += "\n";
            else
              description += text;
          }
        }
        if (description == null)
          description = summaryElement.Value.Trim();
        if (type.Description != description || type.OfficeVersion != officeVersion || type.Tag != tag)
        {

          type.Description = description;
          type.OfficeVersion = officeVersion;
          type.Tag = tag;
          modifiedTypeDescriptionsCount++;
          OpenXmlDatabase.SaveChanges();
          if (VerboseLevel > 0)
            Console.WriteLine($" modified");
        }
        else
        if (VerboseLevel > 0)
          Console.WriteLine($" OK");
      }
      else
      {
        missingTypeDescriptionsCount++;
      }
    }
  }
}
