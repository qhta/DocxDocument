using DocumentFormat.OpenXml.EMMA;

namespace ModelGen;

/// <summary>
/// Represents the common data of TypeInfo, PropInfo, EnumInfo.
/// </summary>
public class ModelElement: IOwnedElement
{
  /// <summary>
  /// Owner of the element (can be of any object).
  /// </summary>
  public object? Owner {get; set;}

  /// <summary>
  /// Name of the element (as read from the source library).
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// New name of the element (with a namespace) used if the element is renamed.
  /// </summary>
  public QualifiedName? NewName { get; set; }

  /// <summary>
  /// Status of acceptance for the further processing.
  /// </summary>
  private ARS Acceptance;
  
  /// <summary>
  /// Specifies whether the element is accepted for further processing.
  /// </summary>
  public bool IsAccepted { get => Acceptance == ARS.Accepted; set { if (value) Acceptance = ARS.Accepted; else Acceptance=ARS.Rejected; } }

  /// <summary>
  /// Specifies whether the element is rejected from further processing.
  /// </summary>
  public bool IsRejected { get => Acceptance == ARS.Rejected; set { if (value) Acceptance = ARS.Rejected; else Acceptance=ARS.None; } }

  /// <summary>
  /// Specifies whether the element is used by other elements.
  /// </summary>
  public bool IsUsed { get; set;}

  /// <summary>
  /// Specifies whether the element is converted to other element.
  /// </summary>
  public bool IsConverted { get; set; }

  /// <summary>
  /// Specifies whether some other element is converted to this element.
  /// </summary>
  public bool IsConvertedTo { get; set; }

  /// <summary>
  /// Short text description of this element.
  /// </summary>
  public string? Summary { get; set; }

  /// <summary>
  /// Xml documentation assigned to this element.
  /// </summary>
  public XElement? Documentation { get; set; }

  /// <summary>
  /// Custom attributes assigned to this element
  /// </summary>
  public OwnedCollection<CustomAttribInfo> CustomAttributes { get; }

  
  public ModelElement(string name)
  {
    Name = name;
    CustomAttributes = new OwnedCollection<CustomAttribInfo>(this);
  }
}