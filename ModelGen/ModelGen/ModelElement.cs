namespace ModelGen;

/// <summary>
/// Represents the common data of TypeInfo, PropInfo, EnumInfo.
/// </summary>
public class ModelElement: IOwnedElement
{
  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="name"></param>
  public ModelElement(string name)
  {
    Name = name;
    CustomAttributes = new OwnedCollection<CustomAttribInfo>(this);
  }
  
  /// <summary>
  /// Owner of the element (can be of any object).
  /// </summary>
  public object? Owner {get; set;}

  /// <summary>
  /// Name of the element (as read from the source library) or declared on creation.
  /// </summary>
  public string Name { get; /*set; */}

  /// <summary>
  /// New name of the element used if the element is renamed.
  /// </summary>
  public string? NewName { get; set; }

  /// <summary>
  /// Status of acceptance for the further processing.
  /// </summary>
  public bool? Acceptance
  { 
    get; 
    private set; 
  }
  
  /// <summary>
  /// Specifies whether the element is accepted for further processing.
  /// </summary>
  public bool IsAccepted { get => Acceptance == true; set { if (value) Acceptance = true; else Acceptance = false; } }

  /// <summary>
  /// Specifies whether the element is rejected from further processing.
  /// </summary>
  public bool IsRejected { get => Acceptance == false; set { if (value) Acceptance = false; else Acceptance = true; } }

  /// <summary>
  /// Status of checked usage.
  /// </summary>
  public bool IsUsed
  { 
    get; 
    set; 
  }

  /// <summary>
  /// Status of validity check.
  /// </summary>
  public bool? Validity
  { 
    get; 
    set; 
  }
  
  /// <summary>
  /// Specifies whether the element is accepted for further processing.
  /// </summary>
  public bool IsValid { get => Validity == true; set { if (value) Validity = true; else Validity = false; } }

  /// <summary>
  /// Specifies whether the element is rejected from further processing.
  /// </summary>
  public bool IsInvalid { get => Validity == false; set { if (value) Validity = false; else Validity = true; } }
  /// <summary>

  /// <summary>
  /// Specifies whether the new name is different from original name.
  /// </summary>
  public bool IsRenamed => NewName!=null && NewName != Name;

  /// <summary>
  /// Specifies whether the element is converted to other element.
  /// </summary>
  public bool IsConverted { get; set; }

  /// <summary>
  /// Specifies whether some other element is converted to this element.
  /// </summary>
  public bool IsConvertedTo { get; set; }

  /// <summary>
  /// Xml documentation assigned to this element.
  /// </summary>
  public virtual ElementDocs? Documentation { get; set; }

  public string? Description
  {
    get
    {
      var summary = Documentation?.Summary;
      if (summary!=null)
        return summary.Value;
      return null;
    }
  }

  /// <summary>
  /// Schema for OpenXml format
  /// </summary>
  public ElementSchema? Schema { get; set; }

  /// <summary>
  /// Version of Office when the element is available.
  /// </summary>
  public string? Availability { get; set; }

  /// <summary>
  /// Custom attributes assigned to this element
  /// </summary>
  public OwnedCollection<CustomAttribInfo> CustomAttributes { get; }


}