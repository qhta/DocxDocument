using DocumentFormat.OpenXml.Office2013.Drawing.Chart;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FullReference Class.
/// </summary>
public static class FullReferenceConverter
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public static String? GetSequenceOfReferences(FullReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSequenceOfReferences(FullReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SequenceOfReferences { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FullReference? CreateModelElement(FullReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FullReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FullReference? value)
    where OpenXmlElementType : FullReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      return openXmlElement;
    }
    return default;
  }
}