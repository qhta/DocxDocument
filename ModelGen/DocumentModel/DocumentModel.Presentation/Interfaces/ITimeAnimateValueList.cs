namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeAnimateValueList Class.
/// </summary>
public interface ITimeAnimateValueList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ITimeAnimateValue>? TimeAnimateValues { get ; set; }
  
}
