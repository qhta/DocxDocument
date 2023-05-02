namespace DocumentModel.Math;

/// <summary>
///   This element specifies any properties of the math argument. 
///   1 represents that it is one size larger than normal, 2 represents that it is two sizes larger than normal, 
///   -1 represents that it is one size smaller than normal, and -2 represents that it is two sizes smaller than normal.  
///   The list below indicates the default starting sizes for each argument, if it is not in this list, 
///   then the size cannot be changed on that argument. 
///   <list type="bullet">
///    <item>
///     box base:  0 
///    </item><item>
///     group-character base:  0  
///    </item><item>
///     lower limit limit:  -1 
///    </item><item>
///     upper limit limit:  -1 
///    </item><item>
///     n-ary operator subscript:  -1 
///    </item><item>
///     n-ary operator superscript:  -1 
///    </item><item>
///     radical degree:  -2 
///    </item><item>
///     pre-sub-superscript subscript:  -1 
///    </item><item>
///     pre-sub-superscript superscript:  -1 
///    </item><item>
///     subscript subscript:  -1 
///    </item><item>
///     sub-supersript subscript:  -1 
///    </item><item>
///     sub-supersript superscript:  -1 
///    </item><item>
///     superscript superscript:  -1 
///    </item>
///   </list>
/// </summary>
public class ArgumentProperties: ModelElement
{
  /// <summary>
  ///   Argument Size.
  /// </summary>
  public Int32? ArgumentSize { get; set; }
}