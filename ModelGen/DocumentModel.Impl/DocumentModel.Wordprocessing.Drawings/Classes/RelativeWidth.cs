namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public class RelativeWidthImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>, RelativeWidth
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId
  {
    get => (SizeRelativeHorizontallyKind?)OpenXmlElement?.ObjectId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ObjectId = (DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues?)value;
    }
  }
  
}
