namespace DocumentModel;

/// <summary>
///   Defines the MenuSeparatorNoTitle Class.
/// </summary>
public interface MenuSeparatorNoTitle
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ
  /// </summary>
  public string? QualifiedId { get; set; }
  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get; set; }
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get; set; }
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public string? InsertAfterQualifiedId { get; set; }
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQualifiedId { get; set; }
}