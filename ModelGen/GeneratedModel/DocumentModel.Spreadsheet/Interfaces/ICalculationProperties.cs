namespace DocumentModel.Spreadsheet;

public interface ICalculationProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? CalculationId { get ; set; }
  
  public CalculateMode? CalculationMode { get ; set; }
  
  public bool? FullCalculationOnLoad { get ; set; }
  
  public ReferenceMode? ReferenceMode { get ; set; }
  
  public bool? Iterate { get ; set; }
  
  public uint? IterateCount { get ; set; }
  
  public double? IterateDelta { get ; set; }
  
  public bool? FullPrecision { get ; set; }
  
  public bool? CalculationCompleted { get ; set; }
  
  public bool? CalculationOnSave { get ; set; }
  
  public bool? ConcurrentCalculation { get ; set; }
  
  public uint? ConcurrentManualCount { get ; set; }
  
  public bool? ForceFullCalculation { get ; set; }
  
}
