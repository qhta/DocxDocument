namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public interface IStylisticSets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Word.IStyleSet>? StyleSets { get ; set; }
  
}
