namespace DocumentModel.Office2010.Word;

public interface IFillTextEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public INoFillEmpty? NoFillEmpty { get ; set; }
  
  public ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  public IGradientFillProperties? GradientFillProperties { get ; set; }
  
}
