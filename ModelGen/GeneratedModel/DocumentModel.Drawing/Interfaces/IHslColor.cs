namespace DocumentModel.Drawing;

public interface IHslColor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? HueValue { get ; set; }
  
  public int? SatValue { get ; set; }
  
  public int? LumValue { get ; set; }
  
}
