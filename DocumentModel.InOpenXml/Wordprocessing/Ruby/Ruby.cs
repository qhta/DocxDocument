namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a phonetic guide (ruby text) at the current location in the document.
/// A phonetic guide is a run of content with base text at the normal baseline and phonetic guide text displayed above it. This construct is typically used to map words in one language to another phonetically, enabling pronunciation aids for East Asian scripts and other language learning scenarios.
/// </summary>
[OpenXmlType(typeof(DXW.Ruby))]
public partial class Ruby : ModelElement<DXW.Ruby>, IRunContent, IRubyContent
{
 /// <summary>
 /// Properties for the phonetic guide, specifying formatting and alignment options for the ruby text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Ruby.RubyProperties))]
 /// <summary>
 /// Properties for the phonetic guide, specifying formatting and alignment options for the ruby text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Ruby))]
 public RubyProperties? RubyProperties { get => _RubyProperties; set => UpdateField(ref _RubyProperties, value, nameof(RubyProperties)); }

 private RubyProperties? _RubyProperties;
 /// <summary>
 /// Phonetic guide text content, displayed above the base text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Ruby.RubyContent))]
 /// <summary>
 /// Phonetic guide text content, displayed above the base text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Ruby))]
 public IRubyContent? RubyContent { get => _RubyContent; set => UpdateField(ref _RubyContent, value, nameof(RubyContent)); }

 private IRubyContent? _RubyContent;
 /// <summary>
 /// Base text for the phonetic guide, displayed at the normal baseline location.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Ruby.RubyBase))]
 /// <summary>
 /// Base text for the phonetic guide, displayed at the normal baseline location.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Ruby))]
 public RubyBase? RubyBase { get => _RubyBase; set => UpdateField(ref _RubyBase, value, nameof(RubyBase)); }

 private RubyBase? _RubyBase;
}