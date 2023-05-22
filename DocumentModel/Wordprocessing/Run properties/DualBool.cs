namespace DocumentModel;

/// <summary>
/// Dual boolean. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
//[TypeConverter(typeof(DualBoolTypeConverter))]
public abstract class DualBool: TypedModelElement
{
  /// <summary>
  /// Value for regular script.
  /// </summary>
  public bool? Val { get; set; }

  /// <summary>
  /// Value for complex script.
  /// </summary>
  public bool? CS { get; set; }

  ///// <summary>
  ///// Create dual value from a string. 
  ///// String can be a single value or two values separated by comma or semicolon.
  ///// </summary>
  //public DualBool(string str)
  //{
  //  var ss = str.Split(new char[] { ',', ';' });
  //  if (ss.Length <= 2 )
  //  {
  //    if (bool.TryParse(ss[0], out var val))
  //      Val = val;
  //  }
  //  if (ss.Length == 2 )
  //  {
  //    if (bool.TryParse(ss[1], out var valCS))
  //      CS = valCS;
  //  }
  //  else
  //    CS = Val;
  //}

  ///// <summary>
  ///// Create dual value from two boolean values. 
  ///// </summary>
  //public DualBool(bool? val, bool? valCS = null)
  //{
  //  Val = val;
  //  CS = valCS;
  //}


//#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
//  public static implicit operator DualBool(string val)
//  {
//    return new DualBool(val);
//  }

//  public static implicit operator DualBool(bool val)
//  {
//    return new DualBool((bool?)val);
//  }

//  public static implicit operator bool? (DualBool? value) => value?.Val;
//  public static implicit operator DualBool?(bool? value) => value != null ? new DualBool(value) : null;

//  //public static implicit operator (bool?, bool?)? (Dualbool? value) => (value?.Val!=null && value?.ValCS!=null) ? DualBoolean;
//  //public static implicit operator Dualbool?((bool? value, bool? valueCS)) => value != null ? new DualBoolean(value) : null;

//  public override string? ToString()
//  {
//    var str = Val.ToString()?.ToLower();
//    if (CS!=Val)
//      str +=";"+CS.ToString()?.ToLower();
//    return str;
//  }
}