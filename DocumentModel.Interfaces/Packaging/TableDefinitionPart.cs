namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public interface TableDefinitionPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public QueryTableParts QueryTableParts { get; set; }

}