namespace DocumentModel.Wordprocessing;

public interface ILatentStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? DefaultLockedState { get ; set; }
  
  public int? DefaultUiPriority { get ; set; }
  
  public bool? DefaultSemiHidden { get ; set; }
  
  public bool? DefaultUnhideWhenUsed { get ; set; }
  
  public bool? DefaultPrimaryStyle { get ; set; }
  
  public int? Count { get ; set; }
  
}
