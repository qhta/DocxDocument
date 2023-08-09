using InvalidOperationException = System.InvalidOperationException;

namespace ModelGen;

/// <summary>
/// This class parses documentation comments reflected from assembly by Namotion.Reflection.
/// </summary>
public static class CommentDocsParser
{
  public static void ParseDocumentation(ModelElement modelElement, XElement documentation)
  {
    var schema = modelElement.Schema ?? new ElementSchema();
    var isSchemaModified = false;
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
                modelElement.OfficeVersion = text;
              }
              else if (RecognizeAvailabilityContainingString(text, "this property is only available in ", out availability))
              {
                modelElement.OfficeVersion = text;
              }
              else
                AddToSummary(modelElement, subElement);
            }
            else
            {
              AddToSummary(modelElement, subElement);
            }
          }
        }
        else
        {
          var text = xElement.Value.Trim();
          modelElement.Description = text;
        }
      }
      else if (xElement.Name == "remark")
      {
        if (xElement.HasElements)
        {
          var subElements = xElement.Elements().ToList();
          for (int i = 0; i < subElements.Count; i++)
          {
            bool recognized = false;
            var subElement = subElements[i];
            if (subElement.Name == "para" && subElement.Value.TrimEnd().EndsWith("child types:"))
            {
              if (i < subElements.Count - 1)
              {
                subElement = subElements[i + 1];
                if (subElement.Name == "list")
                {
                  if (modelElement is TypeInfo typeInfo)
                  {
                    recognized = ParseChildTypes(typeInfo, subElement.Elements());
                    if (recognized) i++;
                  }
                }
                else
                  throw new InvalidOperationException($"List element expected but \"{subElement.Name}\" found in {nameof(ParseDocumentation)}");
              }
            }
            if (!recognized)
              AddToRemarks(modelElement, subElement);
          }
        }
        else
        {
          var text = xElement.Value.Trim();
          int k = text.IndexOf("http://");
          if (k == -1)
            k = text.IndexOf("urn:");
          if (k >= 0)
          {
            text = text.Substring(k).Trim();
            if (text.EndsWith('.'))
              text = text.Substring(0, text.Length - 1).Trim();
            schema.SchemaUrl = text;
            isSchemaModified = true;
          }
          else
          {
            throw new InvalidOperationException($"Unrecognized remark text \"{text}\" in {nameof(ParseDocumentation)}");
          }
        }
      }
    }
    if (modelElement.Documentation != null)
    {
      var summary = modelElement.Documentation.Summary;
      if (summary != null)
      {
        var newDescription = summary.GetText();
        if (newDescription!=null && (modelElement.Description == null || modelElement.Description.Length != newDescription.Length))
        {
          modelElement.Description = newDescription;
          modelElement.Documentation.Remove(summary);
          if (!modelElement.Documentation.Any())
            modelElement.Documentation = null;
        }
      }
    }
    if (isSchemaModified)
      modelElement.Schema = schema;
  }

  private static bool ParseChildTypes(TypeInfo modelElement, IEnumerable<XElement> xElements)
  {
    foreach (var xElement in xElements)
    {
      if (xElement.Name == "item")
      {
        if (!GetChildType(xElement, out var childTypeName, out var childTypeTag))
          return false;
      }
    }
    return true;
  }

  private static bool GetChildType(XElement xElement, out string childTypeName, out string? childTypeTag)
  {
    if (xElement.HasElements)
    {
      childTypeName = null!;
      childTypeTag = null;
      foreach (var subElement in xElement.Elements())
      {
        if (subElement.Name == "item")
          GetChildType(subElement, out childTypeName, out childTypeTag);
        else
        if (subElement.Name == "description")
          GetChildType(subElement, out childTypeName, out childTypeTag);
        else
        if (subElement.Name == "see")
          childTypeName = GetChildTypeFromSee(subElement);
        else
        if (subElement.Name == "c")
          childTypeTag = subElement.Value;
        else
          throw new InvalidOperationException($"Unrecognized element {subElement.Name} found in {xElement.Name} in {nameof(GetChildType)}");
      }
      if (childTypeName != null)
        return true;
      throw new InvalidOperationException($"Unknown child type name in element {xElement.Name} in {nameof(GetChildType)}");
    }
    else
      throw new InvalidOperationException($"Element {xElement.Name} must have children in {nameof(GetChildType)}");
  }

  private static string GetChildTypeFromSee(XElement xElement)
  {
    var cref = xElement.Attribute("cref")?.Value;
    if (cref != null)
    {
      if (cref.StartsWith("T:"))
        return cref.Substring(2);
      else
        throw new InvalidOperationException($"cref attribute \"{cref}\" should start with \"T:\" in {nameof(GetChildTypeFromSee)}");
    }
    else
      throw new InvalidOperationException($"cref attribute not found {xElement.Name} in {nameof(GetChildTypeFromSee)}");
  }


  private static void AddToSummary(ModelElement modelElement, XElement xElement)
  {
    if (modelElement.Documentation == null)
      modelElement.Documentation = new ElementDocs();
    var summary = modelElement.Documentation.FirstOrDefault(item => item.Name == "summary");
    if (summary == null)
    {
      summary = new XElement("summary");
      modelElement.Documentation.Add(summary);
    }
    summary.Add(xElement);
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="modelElement"></param>
  /// <param name="xElement"></param>
  private static void AddToRemarks(ModelElement modelElement, XElement xElement)
  {
    if (modelElement.Documentation == null)
      modelElement.Documentation = new ElementDocs();
    var remarks = modelElement.Documentation.FirstOrDefault(item => item.Name == "remarks");
    if (remarks == null)
    {
      remarks = new XElement("remarks");
      modelElement.Documentation.Add(remarks);
    }
    remarks.Add(xElement);
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
      var restStr = text.Substring(k + specificText.Length).Trim();
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