namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
public class LatentStylesImpl: ModelElementImpl, LatentStyles
{
  public DocumentFormat.OpenXml.Wordprocessing.LatentStyles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LatentStyles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  public Boolean? DefaultLockedState
  {
    get => (Boolean?)OpenXmlElement?.DefaultLockedState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultLockedState = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  public Int32? DefaultUiPriority
  {
    get => (Int32?)OpenXmlElement?.DefaultUiPriority?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultUiPriority = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  public Boolean? DefaultSemiHidden
  {
    get => (Boolean?)OpenXmlElement?.DefaultSemiHidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultSemiHidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  public Boolean? DefaultUnhideWhenUsed
  {
    get => (Boolean?)OpenXmlElement?.DefaultUnhideWhenUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultUnhideWhenUsed = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  public Boolean? DefaultPrimaryStyle
  {
    get => (Boolean?)OpenXmlElement?.DefaultPrimaryStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultPrimaryStyle = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  public Int32? Count
  {
    get => (Int32?)OpenXmlElement?.Count?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Count = (System.Int32?)value;
    }
  }
  
  public Collection<LatentStyleExceptionInfo>? LatentStyleExceptionInfos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
