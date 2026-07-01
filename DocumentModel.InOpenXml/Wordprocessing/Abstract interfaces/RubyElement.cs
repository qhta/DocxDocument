namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for Ruby elements.
/// </summary>
[DataContract]
[XmlRoot("RubyElement", Namespace = "DocumentModel.Wordprocessing")]
public partial class RubyElement : ModelElement //<DXW.RubyElement>
{
 /// <summary>
 /// Specifies whether this is a Ruby element.
 /// </summary>
 public bool Ruby { get => _Ruby; set => UpdateField(ref _Ruby, value, nameof(Ruby)); }
 private bool _Ruby;
}