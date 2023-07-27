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
  /// Status of acceptance for the further processing.
  /// </summary>
  public bool? Accepted { get; set; }

  /// <summary>
  /// Specifies whether the element is accepted for further processing.
  /// </summary>
  [XmlIgnore]
  public bool IsAccepted { get => Accepted == true; set { if (value) Accepted = true; else Accepted = false; } }

  /// <summary>
  /// Specifies whether the element is rejected from further processing.
  /// </summary>
  [XmlIgnore]
  public bool IsRejected { get => Accepted == false; set { if (value) Accepted = false; else Accepted = true; } }

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

  /// <summary>
  /// Status of validity check.
  /// </summary>
  public bool? Valid
  {
    get;
    set;
  }

  /// <summary>
  /// Specifies whether the element is accepted for further processing.
  /// </summary>
  [XmlIgnore]
  public bool IsValid { get => Valid == true; set { if (value) Valid = true; else Valid = false; } }

  /// <summary>
  /// Specifies whether the element is rejected from further processing.
  /// </summary>
  [XmlIgnore]
  public bool IsInvalid { get => Valid == false; set { if (value) Valid = false; else Valid = true; } }
  /// <summary>

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

  /////// <summary>
  /////// Xml documentation assigned to this element.
  /////// </summary>
  //[XmlIgnore]
  //public ElementDocs? Documentation { get; set; }

  /// <summary>
  /// Single-paragraph description.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Multi-paragraph description.
  /// </summary>
  public Summary? Summary { get; set; }

  /// <summary>
  /// Gets a collection of XElement from <see cref="Description"/> and <see cref="Summary"/>.
  /// </summary>
  /// <returns></returns>
  public virtual IEnumerable<XElement>? GetDocumentation()
  {
    if (Description == null && Summary == null)
      return null;
    var documentation = new Collection<XElement>();
    XElement? summary = null;
    if (this.Description != null)
      documentation.Add(summary = new XElement("summary", this.Description));
    if (this.Summary != null)
    {
      if (summary == null)
        documentation.Add(summary = new XElement("summary"));
      foreach (var item in this.Summary)
        summary.Add(new XElement("para", item));
    }
    return documentation;
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
  /// Adds a <see cref="CustomAttrib"/> creating <see cref="CustomAttributes"/>.
  /// </summary>
  /// <param name="attribInfo"></param>
  public void Add(CustomAttrib attribInfo)
  {
    if (CustomAttributes == null)
      CustomAttributes = new CustomAttributes(this);
    CustomAttributes.Add(attribInfo);
  }

}