using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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
  private int missingPropDescriptionsCount;
  private int modifiedPropDescriptionsCount;
  private int foundMemberTypesCount;
  private int addedMemberTypesCount;


  public void ScanDocumentationFile()
  {
    OpenXmlDocumentation = OpenXmlDocumentationFile(OpenXmlAssembly);
    OpenXmlFrameworkDocumentation = OpenXmlDocumentationFile(OpenXmlFrameworkAssembly);
    ScanTypeDescriptions();
    ScanPropertiesDescriptions();
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
      Console.WriteLine($"Found type members {foundMemberTypesCount}");
      Console.WriteLine($"Added type members {addedMemberTypesCount}");
    }
  }

  public void ScanPropertiesDescriptions()
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Scanning properties descriptions");
    foreach (var prop in OpenXmlDatabase.Properties
               .Include(p => p.ParentType).ThenInclude(t => t!.Namespace))
    {
      foundPropsCount++;
      if (VerboseLevel == 1)
        if (foundPropsCount % 100 == 0)
          Console.Write(".");
      TryAddPropertyDescription(prop);
    }
    if (VerboseLevel > 0)
    {
      Console.WriteLine();
      Console.WriteLine($"Modified property descriptions {modifiedPropDescriptionsCount}");
      Console.WriteLine($"Missing property descriptions {missingPropDescriptionsCount}");
    }
  }

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
        var description = ParseSummaryElement(summaryElement, out var officeVersion, out var tag);
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
        else if (VerboseLevel > 0)
          Console.WriteLine($" OK");
        TryAddTypeMembers(type, typeElement);
        return;
      }
    }
    Console.WriteLine($" missing");
    missingTypeDescriptionsCount++;
  }

  private void TryAddPropertyDescription(OpenXmlModels.Property prop)
  {
    var type = prop.ParentType;
    if (VerboseLevel > 0)
      Console.Write($"Property {GetFullName(type)}.{prop.Name} description");
    var propTag = $"P:{type!.Namespace?.Name}.{type.Name}.{prop.Name}";
    var xDocument = type.AssemblyId == 1 ? OpenXmlDocumentation : OpenXmlFrameworkDocumentation;
    var propElement = xDocument.Descendants("member")
      .FirstOrDefault(e => e.Attribute("name")?.Value == propTag);
    if (propElement != null)
    {
      var summaryElement = propElement.Element("summary");
      if (summaryElement != null)
      {
        var description = ParseSummaryElement(summaryElement, out var officeVersion, out var tag);
        if (prop.Description != description || prop.OfficeVersion != officeVersion || prop.Tag != tag)
        {

          prop.Description = description;
          prop.OfficeVersion = officeVersion;
          prop.Tag = tag;
          modifiedPropDescriptionsCount++;
          OpenXmlDatabase.SaveChanges();
          if (VerboseLevel > 0)
            Console.WriteLine($" modified");
        }
        else if (VerboseLevel > 0)
          Console.WriteLine($" OK");
        return;
      }
    }
    Console.WriteLine($" missing");
    missingPropDescriptionsCount++;
  }

  private static string? ParseSummaryElement(XElement summaryElement, out byte? officeVersion, out string? tag)
  {
    string? description = null;
    officeVersion = null;
    tag = null;
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
      else if (text.Contains("is serialized out as xml"))
      {
        if (text.EndsWith("."))
          text = text.Substring(0, text.Length - 1);
        var k = text.LastIndexOf(' ');
        if (k != -1)
          tag = text.Substring(k + 1);
        if (tag == ":")
          tag = null;
      }
      else
      {
        if (description != null)
          description += "\n";
        else
          description += text;
      }
    }
    if (description==null)
    {
      var firstNode = summaryElement.FirstNode;
      if (firstNode != null && firstNode.NodeType==XmlNodeType.Text)
      {
        description = (firstNode as XText)?.Value.Trim();
      }
    }
    return description;
  }

  private void TryAddTypeMembers(OpenXmlModels.Type type, XElement typeElement)
  {
    var remarksElement = typeElement.Element("remarks");
    if (remarksElement != null)
    {
      var paraElement = remarksElement.Element("para");
      if (paraElement != null)
      {
        var text = paraElement.Value.Trim();
        if (text == "The following table lists the possible child types:")
        {
          var listElement = remarksElement.Element("list");
          if (listElement != null)
          {
            ParseRemarksElement(type, listElement);
          }
        }
      }
    }
  }

  private void ParseRemarksElement(OpenXmlModels.Type type, XElement listElement)
  {
    if (VerboseLevel > 0)
      Console.Write($"Type {GetFullName(type)} members");
    foreach (var itemElement in listElement.Descendants("item"))
    {
      var descriptionElement = itemElement.Element("description");
      if (descriptionElement != null)
      {
        var seeElement = descriptionElement.Element("see");
        if (seeElement != null)
        {
          var crefAttribute = seeElement.Attribute("cref");
          if (crefAttribute != null)
          {
            var crefValue = crefAttribute.Value;
            if (crefValue.StartsWith("T:"))
            {
              var memberName = crefValue.Substring(2);
              var k = memberName.LastIndexOf('.');
              if (k != -1)
              {
                var nsName = memberName.Substring(0, k);
                var typeName = memberName.Substring(k + 1);
                var ns = OpenXmlDatabase.Namespaces.FirstOrDefault(n => n.Name == nsName);
                if (ns != null)
                {
                  var memberType = OpenXmlDatabase.Types.FirstOrDefault(t =>
                    t.NamespaceId == ns.Id && t.Name == typeName);
                  if (memberType != null)
                  {
                    var memberTypeItem = OpenXmlDatabase.MemberTypes
                      .FirstOrDefault(mt => mt.ParentTypeId == type.Id && mt.MemberTypeId == memberType.Id);
                    if (memberTypeItem == null)
                    {
                      memberTypeItem = new OpenXmlModels.MemberType
                      {
                        ParentTypeId = type.Id,
                        MemberTypeId = memberType.Id
                      };
                      OpenXmlDatabase.MemberTypes.Add(memberTypeItem);
                      OpenXmlDatabase.SaveChanges();
                      addedMemberTypesCount++;
                    }
                    else
                    {
                      foundMemberTypesCount++;
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
}
