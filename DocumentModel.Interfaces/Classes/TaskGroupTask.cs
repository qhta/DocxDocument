namespace DocumentModel;

/// <summary>
///   Defines the TaskGroupTask Class.
/// </summary>
public interface TaskGroupTask: CollectionItem
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
  ///   onAction
  /// </summary>
  public string? OnAction { get; set; }
  /// <summary>
  ///   isDefinitive
  /// </summary>
  public bool? IsDefinitive { get; set; }
  /// <summary>
  ///   image
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   imageMso
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   getImage
  /// </summary>
  public string? GetImage { get; set; }
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
  ///   description
  /// </summary>
  public string? Description { get; set; }
  /// <summary>
  ///   getDescription
  /// </summary>
  public string? GetDescription { get; set; }
  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }
  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }
}