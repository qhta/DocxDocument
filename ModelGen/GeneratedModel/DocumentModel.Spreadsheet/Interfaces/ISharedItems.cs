namespace DocumentModel.Spreadsheet;

public interface ISharedItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ContainsSemiMixedTypes { get ; set; }
  
  public bool? ContainsNonDate { get ; set; }
  
  public bool? ContainsDate { get ; set; }
  
  public bool? ContainsString { get ; set; }
  
  public bool? ContainsBlank { get ; set; }
  
  public bool? ContainsMixedTypes { get ; set; }
  
  public bool? ContainsNumber { get ; set; }
  
  public bool? ContainsInteger { get ; set; }
  
  public double? MinValue { get ; set; }
  
  public double? MaxValue { get ; set; }
  
  public DateTime? MinDate { get ; set; }
  
  public DateTime? MaxDate { get ; set; }
  
  public uint? Count { get ; set; }
  
  public bool? LongText { get ; set; }
  
}
