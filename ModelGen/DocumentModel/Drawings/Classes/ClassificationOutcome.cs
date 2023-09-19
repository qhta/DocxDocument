namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ClassificationOutcome Class.
/// </summary>
public partial class ClassificationOutcome
{
  
  /// <summary>
  ///   classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  [SchemaAttr("classificationOutcomeType")]
  public DocumentModel.Drawings.ClassificationOutcomeType? ClassificationOutcomeType { get; set; }
  
}
