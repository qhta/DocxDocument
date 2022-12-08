namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public class PictureOptionsImpl: ModelElementImpl, PictureOptions
{
  public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PictureOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public Boolean? ApplyToFront
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public Boolean? ApplyToSides
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public Boolean? ApplyToEnd
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public PictureFormatKind? PictureFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
        return (PictureFormatKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.PictureFormat{ Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit
  {
    get;
    set;
  }
  
}
