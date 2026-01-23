namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents language codes for three script types in WordprocessingML documents: regular (normal), complex (bidirectional), and East Asian scripts.
/// This class enables specification of language settings for spell checking, grammar checking, and text processing in multilingual documents.
/// </summary>
public partial class Languages : ModelElement<DXW.Languages>
{
    /// <summary>
    /// Language code for all regular (normal) scripts, typically used for Western languages.
    /// </summary>
    public string? Regular { get => _Regular; set => UpdateField(ref _Regular, value, nameof(Regular)); }

    private string? _Regular;
    /// <summary>
    /// Language code for complex (bidirectional) scripts, such as Arabic, Hebrew, or Thai.
    /// </summary>
    public string? ComplexScript { get; set; }
    /// <summary>
    /// Language code for East Asian scripts, such as Chinese, Japanese, or Korean.
    /// </summary>
    public string? EastAsia { get; set; }
}