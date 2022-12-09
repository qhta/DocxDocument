namespace DocumentModel.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public class ReadModeInkLockDownImpl: ModelElementImpl, ReadModeInkLockDown
{
  public DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  public Boolean? UseActualPages
  {
    get => (Boolean?)OpenXmlElement?.UseActualPages?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseActualPages = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  public UInt32? Width
  {
    get => (UInt32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  public UInt32? Height
  {
    get => (UInt32?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  public String? FontSize
  {
    get => (String?)OpenXmlElement?.FontSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontSize = (System.String?)value;
    }
  }
  
}
