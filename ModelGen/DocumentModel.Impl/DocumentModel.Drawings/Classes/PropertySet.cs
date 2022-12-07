namespace DocumentModel.Drawings;

/// <summary>
/// Property Set.
/// </summary>
public class PropertySetImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>, PropertySet
{
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public PresentationLayoutVariables? PresentationLayoutVariables
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style3? Style
  {
    get;
    set;
  }
  
}
