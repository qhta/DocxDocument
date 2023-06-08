using System.Xml.Linq;

using Namotion.Reflection;

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

  public static Metadata GetElementMetadata(XElement documentation)
  {
    Metadata metadata = new Metadata();
    var items = new List<XElement>();
    foreach (var xElement in documentation.Elements())
    {
      if (xElement.Name == "summary")
      {
        foreach (var subElement in xElement.Elements())
        {
          if (subElement.Name == "para")
          {
            var text = subElement.Value.Trim();
            if (text.StartsWith("Represents the following"))
            {
              int k = text.IndexOf(':');
              if (k >= 0)
              {
                var tag = text.Substring(k + 1).Trim();
                if (tag.EndsWith('.'))
                  tag = tag.Substring(0, tag.Length - 1).Trim();
                if (text.Contains("attribute"))
                  metadata.SchemaAttribute = tag;
                else
                  metadata.SchemaElement = tag;
              }
            }
            else if (text.StartsWith("When the object is serialized out as xml, it's qualified name is "))
            {
              int k = "When the object is serialized out as xml, it's qualified name is ".Length;
              text = text.Substring(k).Trim();
              if (text.EndsWith('.'))
                text = text.Substring(0, text.Length - 1).Trim();
              metadata.SchemaElement = text;
            }
            else if (text.StartsWith("This class is available in "))
            {
              int k = "This class is available in ".Length;
              text = text.Substring(k).Trim();
              if (text.EndsWith('.'))
                text = text.Substring(0, text.Length - 1).Trim();
              metadata.Availability = text;
            }
            else
            {
              int k = text.IndexOf("this property is only available in ");
              if (k >= 0)
              {
                k += "this property is only available in ".Length;
                text = text.Substring(k).Trim();
                if (text.EndsWith('.'))
                  text = text.Substring(0, text.Length - 1).Trim();
                metadata.Availability = text;
              }
              else
                items.Add(subElement);
            }
          }
          else
            items.Add(subElement);
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
            metadata.SchemaUrl = text;
          }
        }
      }
      else 
      if (xElement.Name == "inheritdoc"  || xElement.Name == "typeparam")
      {
        // ignore
      }
      else
        ;
    }
    if (items.Count == 1 && items.First().Name=="para")
    {
      metadata.SummaryText = items.First().Value;
    }
    else if (items.Count > 0)
    {
      metadata.Summary = new XElement("summary");
      foreach (var item in items)
        metadata.Summary.Add(item);
    }

    return metadata;
  }
}