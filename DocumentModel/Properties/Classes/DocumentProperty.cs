using System.Runtime.Serialization;

namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
[KnownType(typeof(CustomDocumentProperty))]
public partial class DocumentProperty
{
    /// <summary>
    /// Custom File Property Name
    /// </summary>
    [XmlAttribute]
    public string? Name { get; set; }

    /// <summary>
    /// Value of the property
    /// </summary>
    public object? Value { get; set; }
}
