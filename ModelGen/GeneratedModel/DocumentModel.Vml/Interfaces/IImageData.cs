namespace DocumentModel.Vml;

public interface IImageData // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Id { get ; set; }
  
  public string? ChromAKey { get ; set; }
  
  public string? CropLeft { get ; set; }
  
  public string? CropTop { get ; set; }
  
  public string? CropRight { get ; set; }
  
  public string? CropBottom { get ; set; }
  
  public string? Gain { get ; set; }
  
  public string? BlackLevel { get ; set; }
  
  public string? Gamma { get ; set; }
  
  public ITrueFalseValue? Grayscale { get ; set; }
  
  public ITrueFalseValue? BiLevel { get ; set; }
  
  public string? EmbossColor { get ; set; }
  
  public string? RecolorTarget { get ; set; }
  
  public string? Title { get ; set; }
  
  public ITrueFalseValue? DetectMouseClick { get ; set; }
  
  public string? RelId { get ; set; }
  
  public string? RelationshipId { get ; set; }
  
  public string? Picture { get ; set; }
  
  public string? RelHref { get ; set; }
  
}
