using System;
using System.Collections.Generic;
using System.Linq;

namespace EVEOnlineSingleSignOnWinForms.Extensions {
    public static class DictionaryExtensions {
        public static Dictionary<string, string> ToDictionary(
            this IEnumerable<KeyValuePair<string, string>> dictionary) {
            return dictionary.ToDictionary(kv => kv.Key, kv => kv.Value,
                StringComparer.OrdinalIgnoreCase);
        }
    }
}