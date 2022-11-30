namespace DocumentModel.Office.SpreadSheetML.Y2022.PivotVersionInfo;

/// <summary>
/// Defines the PivotVersionInfo Class.
/// </summary>
public interface IPivotVersionInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<System.String>? RequiredFeatureXsdstrings { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? LastUpdateFeatureXsdstrings { get ; set; }
  
}
