namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the BackstageTab Class.
/// </summary>
public class BackstageTab: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   idMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   insertAfterMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get; set; }

  /// <summary>
  ///   enabled, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   label, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   title, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   getTitle, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetTitle { get; set; }

  /// <summary>
  ///   columnWidthPercent, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? ColumnWidthPercent { get; set; }

  /// <summary>
  ///   firstColumnMinWidth, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? FirstColumnMinWidth { get; set; }

  /// <summary>
  ///   firstColumnMaxWidth, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? FirstColumnMaxWidth { get; set; }

  /// <summary>
  ///   secondColumnMinWidth, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? SecondColumnMinWidth { get; set; }

  /// <summary>
  ///   secondColumnMaxWidth, this property is Ionly available Iin Office 2010 and later.
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
