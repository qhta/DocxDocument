namespace DocumentModel.Vml.Office;

public interface ICallout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  public ITrueFalseValue? On { get ; set; }
  
  public string? Type { get ; set; }
  
  public string? Gap { get ; set; }
  
  public Angle? Angle { get ; set; }
  
  public ITrueFalseValue? DropAuto { get ; set; }
  
  public string? Drop { get ; set; }
  
  public string? Distance { get ; set; }
  
  public ITrueFalseValue? LengthSpecified { get ; set; }
  
  public string? Length { get ; set; }
  
  public ITrueFalseValue? AccentBar { get ; set; }
  
  public ITrueFalseValue? TextBorder { get ; set; }
  
  public ITrueFalseValue? MinusX { get ; set; }
  
  public ITrueFalseValue? MinusY { get ; set; }
  
}
