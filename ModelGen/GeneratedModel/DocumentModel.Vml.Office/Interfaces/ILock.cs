namespace DocumentModel.Vml.Office;

public interface ILock // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  public ITrueFalseValue? Position { get ; set; }
  
  public ITrueFalseValue? Selection { get ; set; }
  
  public ITrueFalseValue? Grouping { get ; set; }
  
  public ITrueFalseValue? Ungrouping { get ; set; }
  
  public ITrueFalseValue? Rotation { get ; set; }
  
  public ITrueFalseValue? Cropping { get ; set; }
  
  public ITrueFalseValue? Verticies { get ; set; }
  
  public ITrueFalseValue? AdjustHandles { get ; set; }
  
  public ITrueFalseValue? TextLock { get ; set; }
  
  public ITrueFalseValue? AspectRatio { get ; set; }
  
  public ITrueFalseValue? ShapeType { get ; set; }
  
}
