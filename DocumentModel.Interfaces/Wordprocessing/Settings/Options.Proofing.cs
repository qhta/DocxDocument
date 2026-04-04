using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface IOptions : IModelObject
{

  /// <summary> 
  /// True if Microsoft Word checks grammar and marks errors automatically as you type. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarasyoutype?view=word-pia"/>
  public bool? CheckGrammarAsYouType { get; set; }

  /// <summary> 
  /// True if Microsoft Word checks grammar while checking spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarwithspelling?view=word-pia"/>
  public bool? CheckGrammarWithSpelling { get; set; }

  /// <summary> 
  /// True if Microsoft Word checks spelling and marks errors automatically as you type. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkspellingasyoutype?view=word-pia"/>
  public bool? CheckSpellingAsYouType { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether to use the contextual speller to check spelling based on 
  /// the context of a word and the words around it. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.contextualspeller?view=word-pia"/>
  public bool? ContextualSpeller { get; set; }

  /// <summary> 
  /// True if Microsoft Word checks for misused words when checking the spelling and grammar in a document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablemisusedwordsdictionary?view=word-pia"/>
  public bool? EnableMisusedWordsDictionary { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) value that, when True, specifies that users be notified when 
  /// additional proofing tools are available for download. Read-write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enableproofingtoolsadvertisement?view=word-pia"/>
  public bool? EnableProofingToolsAdvertisement { get; set; }

  /// <summary> 
  /// True if file name extensions, MS-DOS paths, e-mail addresses, server and share names (also known as UNC 
  /// paths), and Internet addresses (also known as URLs) are ignored while checking spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreinternetandfileaddresses?view=word-pia"/>
  public bool? IgnoreInternetAndFileAddresses { get; set; }

  /// <summary> 
  /// True if words that contain numbers are ignored while checking spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoremixeddigits?view=word-pia"/>
  public bool? IgnoreMixedDigits { get; set; }

  /// <summary> 
  /// True if words in all uppercase letters are ignored while checking spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreuppercase?view=word-pia"/>
  public bool? IgnoreUppercase { get; set; }

  /// <summary> 
  /// True displays a message asking the user to verify whether they want to reformat a style or reapply the 
  /// original style formatting when changing the formatting of styles. False reapplies the style formatting to 
  /// the selection without verifying whether the user wants to change the style. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.promptupdatestyle?view=word-pia"/>
  public bool? PromptUpdateStyle { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether to mark words that are repeated when spelling is checked. 
  /// True flags repeated words. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.repeatword?view=word-pia"/>
  public bool? RepeatWord { get; set; }

  /// <summary> 
  /// True if Microsoft Word draws spelling suggestions from the main dictionary only. False if it draws spelling 
  /// suggestions from the main dictionary and any custom dictionaries that have been added. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestfrommaindictionaryonly?view=word-pia"/>
  public bool? SuggestFromMainDictionaryOnly { get; set; }

  /// <summary> 
  /// True if Microsoft Word always suggests alternative spellings for each misspelled word when checking 
  /// spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestspellingcorrections?view=word-pia"/>
  public bool? SuggestSpellingCorrections { get; set; }

}
