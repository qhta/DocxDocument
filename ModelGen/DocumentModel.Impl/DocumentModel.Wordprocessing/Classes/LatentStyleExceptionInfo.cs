namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public class LatentStyleExceptionInfoImpl: ModelElementImpl, LatentStyleExceptionInfo
{
  public DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Primary Style Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  public Boolean? Locked
  {
    get => (Boolean?)OpenXmlElement?.Locked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Locked = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  public Int32? UiPriority
  {
    get => (Int32?)OpenXmlElement?.UiPriority?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UiPriority = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  public Boolean? SemiHidden
  {
    get => (Boolean?)OpenXmlElement?.SemiHidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SemiHidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  public Boolean? UnhideWhenUsed
  {
    get => (Boolean?)OpenXmlElement?.UnhideWhenUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UnhideWhenUsed = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  public Boolean? PrimaryStyle
  {
    get => (Boolean?)OpenXmlElement?.PrimaryStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PrimaryStyle = (System.Boolean?)value;
    }
  }
  
}
