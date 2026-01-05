namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageTab Class.
/// </summary>
public interface BackstageTab:
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
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }

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

  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   getTitle
  /// </summary>
  public string? GetTitle { get; set; }

  /// <summary>
  ///   columnWidthPercent
  /// </summary>
  public Int64? ColumnWidthPercent { get; set; }

  /// <summary>
  ///   firstColumnMinWidth
  /// </summary>
  public Int64? FirstColumnMinWidth { get; set; }

  /// <summary>
  ///   firstColumnMaxWidth
  /// </summary>
  public Int64? FirstColumnMaxWidth { get; set; }

  /// <summary>
  ///   secondColumnMinWidth
  /// </summary>
  public Int64? SecondColumnMinWidth { get; set; }

  /// <summary>
  ///   secondColumnMaxWidth
  /// </summary>
  public Int64? SecondColumnMaxWidth { get; set; }

  /// <summary>
  ///   BackstageGroups.
  /// </summary>
  public BackstageGroups? BackstageGroups { get; set; }

  /// <summary>
  ///   SimpleGroups.
  /// </summary>
  public SimpleGroups? SimpleGroups { get; set; }
}