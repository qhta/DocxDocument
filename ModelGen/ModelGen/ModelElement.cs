using System.ComponentModel;

namespace ModelGen;

/// <summary>
/// Represents the common data of TypeInfo, PropInfo, EnumInfo.
/// </summary>
public class ModelElement : IOwnedElement
{
  /// <summary>
  /// Default constructor. Needed for serialization.
  /// </summary>
  public ModelElement() { }

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="name"></param>
  public ModelElement(string name)
  {
    Name = name;
  }

  /// <summary>
  /// Owner of the element (can be of any object).
  /// </summary>
  [XmlIgnore]
  public object? Owner { get; set; }

  /// <summary>
  /// Name of the element (as read from the source library) or declared on creation.
  /// </summary>
  public string Name { get; set; } = null!;

  /// <summary>
  /// New name of the element used if the element is renamed.
  /// </summary>
  public string? NewName { get; set; }

  /// <summary>
  /// Specifies whether the element is accepted to processing in specific phase
  /// </summary>
  public bool IsAcceptedTo(PPS phase) => RejectedAfterPhase == PPS.None || RejectedAfterPhase >= phase;

  /// <summary>
  /// Specifies whether the element is accepted to further processing after specific phase
  /// </summary>
  public bool IsAcceptedAfter(PPS phase) => RejectedAfterPhase == PPS.None || RejectedAfterPhase > phase;

  /// <summary>
  /// Specifies whether the element is rejected from further processing after specific phase
  /// </summary>
  public bool IsRejectedAfter(PPS phase) => RejectedAfterPhase != PPS.None && RejectedAfterPhase <= phase;

  /// <summary>
  /// Sets <see cref="RejectedAfterPhase"/> to the specific phase.
  /// </summary>
  /// <param name="phase"></param>
  public void SetRejected(PPS phase) { RejectedAfterPhase = phase; }

  private PPS RejectedAfterPhase = PPS.None;

  /// <summary>
  /// Status of acceptance for the further processing.
  /// </summary>
  public bool? Used
  {
    get;
    set;
  }

  /// <summary>
  /// Specifies whether the element is used by other elements.
  /// </summary>
  [XmlIgnore]
  public bool IsUsed { get => Used == true; set { if (value) Used = true; else Used = false; } }

  /// <summary>
  /// Specifies whether the element is not used by other elements.
  /// </summary>
  [XmlIgnore]
  public bool IsUnused { get => Used == false; set { if (value) Used = false; else Used = true; } }

  public bool IsInvalid(PPS pps)
  {
    var result = Errors?.Where(item => item.Phase == pps).Any() == true;
    return result;
  }
  public Errors? Errors { get; private set; }

  public void AddError(PPS pps, ErrorCode code, object[]? args = null)
  {
    if (Errors == null)
      Errors = new Errors();
    Errors.Add(new Error(pps, code, args));
  }

  public bool HasError(PPS pps, ErrorCode code)
  {
    if (Errors == null)
      return false;
    return Errors.Any(error => error.Phase == pps && error.Code == code);
  }

  /// <summary>
  /// Specifies whether the new name is different from original name.
  /// </summary>
  [XmlIgnore]
  public bool IsRenamed => NewName != null && NewName != Name;

  /// <summary>
  /// Specifies whether the element is converted to other element.
  /// </summary>
  [XmlIgnore]
  public bool IsConverted { get; set; }

  /// <summary>
  /// Specifies whether some other element is converted to this element.
  /// </summary>
  [XmlIgnore]
  public bool IsConvertedTo { get; set; }

  /// <summary>
  /// Single-paragraph description.
  /// </summary>
  public string? Description
  {
    get;
    set;
  }

  /// <summary>
  /// Multi-paragraph description.
  /// </summary>
  public ElementDocs? Documentation { get; set; }

  /// <summary>
  /// Gets a string of <see cref="Description"/> or <see cref="Documentation"/>.
  /// </summary>
  /// <returns></returns>
  public virtual string? GetDescription()
  {
    return ModelDocsManager.GetDescription(this);
  }

  /// <summary>
  /// Gets a collection of XElement from <see cref="Description"/> and <see cref="Documentation"/>.
  /// </summary>
  /// <returns></returns>
  public virtual IEnumerable<XElement>? GetDocumentation()
  {
    return ModelDocsManager.GetDocumentation(this);
  }

  /// <summary>
  /// Schema for OpenXml format
  /// </summary>
  [XmlIgnore]
  public ElementSchema? Schema { get; set; }

  /// <summary>
  /// Version of Office when the element is available.
  /// </summary>
  public string? OfficeVersion { get; set; }

  /// <summary>
  /// Custom attributes assigned to this element
  /// </summary>
  [XmlIgnore]
  public CustomAttributes? CustomAttributes { get; protected set; } = null!;

  /// <summary>
  /// Adds a <see cref="CustomAttribInfo"/> creating <see cref="CustomAttributes"/>.
  /// </summary>
  /// <param name="attribInfo"></param>
  public void Add(CustomAttribInfo attribInfo)
  {
    if (CustomAttributes == null)
      CustomAttributes = new CustomAttributes(this);
    CustomAttributes.Add(attribInfo);
  }

}