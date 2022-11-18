using System.Reflection;
using System.Xml.Linq;

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

}