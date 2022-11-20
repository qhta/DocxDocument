namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ICompatExtension))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.IBackgroundProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ICreationId))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.IPredecessorDrawingElementReference))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.DocumentClassification.IClassificationOutcome))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.IDecorative))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.Y2021.ScriptLink.IScriptLink))]
public class NonVisualDrawingPropertiesExtension: INonVisualDrawingPropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
