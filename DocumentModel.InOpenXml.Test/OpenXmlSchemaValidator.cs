using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Validates generated OpenXml XML against the canonical schema set.
/// </summary>
internal static class OpenXmlSchemaValidator
{
  private const string SchemaDirectory = @"d:\OneDrive\VS\Docs\OpenXML\Schema2016";
  private static readonly Lazy<XmlSchemaSet> SchemaSet = new(LoadSchemas);

  public static OpenXmlValidationResult ValidateFile(string xmlFilePath)
  {
    if (string.IsNullOrWhiteSpace(xmlFilePath))
      throw new ArgumentException("Value cannot be null or whitespace.", nameof(xmlFilePath));

    return Validate(settings =>
    {
      var stream = File.OpenRead(xmlFilePath);
      return XmlReader.Create(stream, settings);
    });
  }

  public static OpenXmlValidationResult ValidateXml(string xmlContent)
  {
    if (xmlContent == null)
      throw new ArgumentNullException(nameof(xmlContent));

    xmlContent = xmlContent.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/",
      "http://purl.oclc.org/ooxml/wordprocessingml/");
    xmlContent = xmlContent.Replace("http://schemas.openxmlformats.org/officeDocument/2006/",
      "http://purl.oclc.org/ooxml/officeDocument/");
    xmlContent = NormalizeXmlContent(xmlContent);

    return Validate(settings =>
    {
      var textReader = new StringReader(xmlContent);
      return XmlReader.Create(textReader, settings);
    });
  }

  private static string NormalizeXmlContent(string xmlContent)
  {
    if (string.IsNullOrEmpty(xmlContent))
      return xmlContent;

    var trimmed = xmlContent.TrimStart();
    if (trimmed.Length == 0 || trimmed[0] == '<')
      return xmlContent;

    var lines = xmlContent.Split(["\r\n", "\n", "\r"], StringSplitOptions.None);
    StringBuilder? builder = null;

    for (int i = 0; i < lines.Length; i++)
    {
      var strippedLine = StripLineNumberPrefix(lines[i], out var hadLineNumber);
      if (hadLineNumber)
      {
        builder ??= new StringBuilder(xmlContent.Length);
      }

      if (builder != null)
      {
        builder.Append(strippedLine);
        if (i < lines.Length - 1)
          builder.AppendLine();
      }
    }

    return builder != null ? builder.ToString() : xmlContent;
  }

  private static string StripLineNumberPrefix(string line, out bool hadLineNumber)
  {
    var index = 0;
    while (index < line.Length && char.IsWhiteSpace(line[index]))
      index++;

    var digitStart = index;
    while (index < line.Length && char.IsDigit(line[index]))
      index++;

    if (index > digitStart && index < line.Length && line[index] == ':')
    {
      index++;
      if (index < line.Length && line[index] == ' ')
        index++;
      hadLineNumber = true;
      return line[index..];
    }

    hadLineNumber = false;
    return line;
  }

  private static OpenXmlValidationResult Validate(Func<XmlReaderSettings, XmlReader> readerFactory)
  {
    var errors = new List<string>();
    var settings = CreateReaderSettings(errors);

    using var reader = readerFactory(settings);
    while (reader.Read())
    {
    }

    return new OpenXmlValidationResult(errors.Count == 0, errors);
  }

  private static XmlReaderSettings CreateReaderSettings(ICollection<string> errors)
  {
    var settings = new XmlReaderSettings
    {
      ValidationType = ValidationType.Schema,
      Schemas = SchemaSet.Value,
      DtdProcessing = DtdProcessing.Ignore,
      CloseInput = true,
      ValidationFlags = //XmlSchemaValidationFlags.ReportValidationWarnings |
                        XmlSchemaValidationFlags.ProcessInlineSchema |
                        XmlSchemaValidationFlags.ProcessSchemaLocation
    };

    settings.XmlResolver = new XmlUrlResolver();

    settings.ValidationEventHandler += (_, args) =>
    {
      var severity = args.Severity == XmlSeverityType.Warning ? "Warning" : "Error";
      if (args.Exception is { } schemaException)
      {
        errors.Add($"{severity} ({schemaException.SourceUri}, line {schemaException.LineNumber}, pos {schemaException.LinePosition}): {args.Message}");
      }
      else
      {
        errors.Add($"{severity}: {args.Message}");
      }
    };

    return settings;
  }

  private static XmlSchemaSet LoadSchemas()
  {
    if (!Directory.Exists(SchemaDirectory))
      throw new DirectoryNotFoundException($"Schema folder '{SchemaDirectory}' was not found.");

    var schemaSet = new XmlSchemaSet
    {
      XmlResolver = new XmlUrlResolver()
    };

    foreach (var schemaPath in Directory.EnumerateFiles(SchemaDirectory, "*.xsd", SearchOption.AllDirectories))
    {
      try
      {
        //Debug.WriteLine(schemaPath);
        schemaSet.Add(null, schemaPath);
      }
      catch (XmlSchemaException ex)
      {
        throw new InvalidOperationException($"Cannot load schema '{schemaPath}'. {ex.Message}", ex);
      }
    }

    schemaSet.Compile();
    return schemaSet;
  }
}

internal sealed record OpenXmlValidationResult(bool IsValid, IReadOnlyList<string> Messages);
