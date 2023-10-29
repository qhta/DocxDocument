namespace DocumentModel;
public static class TestUtilities
{
  public static void ThrowError(this Exception ex)
  {
    if (ex.InnerException != null)
      ThrowError(ex.InnerException);
    throw ex;
  }

  public static string? ToDumpString(this object? value)
  {
    if (value is null)
      return null;
    if (value is string str)
      return "\"" + str + "\"";
    var type = value.GetType();
    if (type.IsClass)
    {
      var ss = new List<string>();
      foreach (var propInfo in type.GetProperties())
      {
        var getMethod = propInfo.GetGetMethod();
        if (getMethod!=null)
        {
          var val = getMethod.Invoke(value, new object[]{ });
          if (val!=null)
            ss.Add($"{propInfo.Name} = {ToDumpString(val)}");
        }
      }
      return type.Name+"{ "+ string.Join(", ", ss) +" }";
    }

    return value.ToString();
  }
}
