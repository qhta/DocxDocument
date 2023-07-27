namespace ModelGen;

public static class DocumentationReader
{
  public static IEnumerable<Type>? GetChildItemTypes(XElement documentation, Assembly assembly)
  {
    var crefs = GetSeeCrefs(documentation);
    if (crefs != null)
    {
      var types = new List<Type>();
      foreach (var cref in crefs)
      {
        if (cref.StartsWith("T:"))
        {
          var typeName = cref.Substring(2);
          var type = assembly.GetType(typeName);
          if (type != null)
            types.Add(type);
        }
      }
      return types;
    }
    return null;
  }

  public static IEnumerable<string>? GetSeeCrefs(XElement documentation)
  {
    var listItems = GetRemarkListItems(documentation);
    if (listItems != null)
    {
      var strings = new List<string>();
      foreach (var listItem in listItems)
      {
        var itemContent = GetListItemContent(listItem);
        if (itemContent != null)
        {
          var str = GetFirstSeeCref(itemContent);
          if (str != null)
            strings.Add(str);
        }
      }
      return strings;
    }
    return null;
  }

  public static string? GetSummaryFirstPara(XElement documentation)
  {
    var summaryElement = documentation.Elements().FirstOrDefault(item => item.Name == "summary");
    if (summaryElement != null)
    {
      var str = summaryElement.Value;
      var ss = str.Split("\n");
      if (ss.Length > 0)
        return ss.FirstOrDefault(s => s.Trim() != string.Empty)?.Trim();
    }
    return null;
  }

  public static string? GetRemarkFirstPara(XElement documentation)
  {
    var remarkElement = documentation.Elements().FirstOrDefault(item => item.Name == "remark");
    if (remarkElement != null)
    {
      var str = remarkElement.Value;
      var ss = str.Split("\n");
      if (ss.Length > 0)
        return ss.FirstOrDefault(s => s.Trim() != string.Empty)?.Trim();
    }
    return null;
  }

  public static IEnumerable<XElement>? GetRemarkListItems(XElement documentation)
  {
    var remarkElement = documentation.Elements().FirstOrDefault(item => item.Name == "remark");
    if (remarkElement != null)
    {
      var listElement = remarkElement.Elements().FirstOrDefault(item => item.Name == "list");
      if (listElement != null)
        return listElement.Elements();
    }
    return null;
  }

  public static IEnumerable<XElement>? GetListItemContent(XElement listItem)
  {
    var descriptionElement = listItem.Elements().FirstOrDefault(item => item.Name == "description");
    if (descriptionElement != null)
      return descriptionElement.Elements();
    return listItem.Elements();
  }

  public static string? GetFirstSeeCref(IEnumerable<XElement> itemContent)
  {
    var seeElement = itemContent.FirstOrDefault(item => item.Name == "see");
    if (seeElement != null)
      return seeElement.Attribute((XName)"cref")?.Value;
    return null;
  }

  public static void ParseDocumentation(ModelElement element, XElement documentation)
  {
    var schema = element.Schema ?? new ElementSchema();
    var isSchemaModified = false;
    string? summaryText = null;
    foreach (var xElement in documentation.Elements())
    {
      if (xElement.Name == "summary")
      {
        if (xElement.HasElements)
        {
          foreach (var subElement in xElement.Elements())
          {
            var text = subElement.Value.Trim();
            if (subElement.Name == "para")
            {
              if (RecognizeTagContainingString(text, "Represents the following", out var tag, out var attrib))
              {
                schema.SchemaIsAttrib = attrib;
                schema.SchemaTag = tag;
                isSchemaModified = true;
              }
              else if (RecognizeTagContainingString(text, "When the object is serialized out as xml, it's qualified name is", out tag, out attrib))
              {
                schema.SchemaIsAttrib = attrib;
                schema.SchemaTag = tag;
                isSchemaModified = true;
              }
              else if (RecognizeAvailabilityContainingString(text, "This class is available in ", out var availability))
              {
                element.OfficeVersion = text;
              }
              else if (RecognizeAvailabilityContainingString(text, "this property is only available in ", out availability))
              {
                element.OfficeVersion = text;
              }
              else if (summaryText == null)
                summaryText = text;
            }
            else
            {
              if (summaryText == null)
                summaryText = text;
            }
          }
        }
        else
        {
          var text = xElement.Value.Trim();
          if (summaryText == null)
            summaryText = text;
        }
      }
      else if (xElement.Name == "remark")
      {
        if (!xElement.HasElements)
        {
          var text = xElement.Value.Trim();
          int k = text.IndexOf("http://");
          if (k >= 0)
          {
            text = text.Substring(k).Trim();
            if (text.EndsWith('.'))
              text = text.Substring(0, text.Length - 1).Trim();
            schema.SchemaUrl = text;
            isSchemaModified = true;
          }
        }
      }
    }
    if (summaryText != null)
    {
      element.Description = summaryText;
    }
    if (isSchemaModified)
      element.Schema = schema;
  }

  private static bool RecognizeTagContainingString(string text, string startingText, out string? tag, out bool attrib)
  {
    tag = null;
    attrib = false;
    if (text.StartsWith(startingText))
    {
      var restStr = text.Substring(startingText.Length).Trim();
      if (restStr.StartsWith(":"))
        restStr = text.Substring(1).Trim();
      if (restStr.EndsWith('.'))
        restStr = restStr.Substring(0, restStr.Length - 1).Trim();
      if (text.Contains("attribute"))
        attrib = true;
      tag = GetTag(restStr);
      return true;
    }
    return false;
  }

  private static string? GetTag(string str)
  {
    int k = str.IndexOf(':');
    if (k >= 0)
    {
      var restStr = str.Substring(k + 1).Trim();
      if (restStr.EndsWith('.'))
        restStr = restStr.Substring(0, restStr.Length - 1).Trim();
      return restStr;
    }
    else
      return str;
  }

  private static bool RecognizeAvailabilityContainingString(string text, string specificText, out string? availability)
  {
    availability = null;
    int k = text.IndexOf(specificText);
    if (text.StartsWith(specificText))
    {
      var restStr = text.Substring(k+specificText.Length).Trim();
      if (restStr.StartsWith(":"))
        restStr = text.Substring(1).Trim();
      if (restStr.EndsWith('.'))
        restStr = restStr.Substring(0, restStr.Length - 1).Trim();
      availability = GetTag(restStr);
      return true;
    }
    return false;
  }
}