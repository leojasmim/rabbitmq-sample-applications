using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Common {
    public static class ObjectSerialize {

        public static byte[] Serialize(this object obj) {
            if (obj == null) { return null; }

            var json = JsonConvert.SerializeObject(obj);
            return Encoding.ASCII.GetBytes(json);
        }

        public static object Deserialize(this byte[] arrBytes, Type type) {
            var json = Encoding.Default.GetString(arrBytes);
            return JsonConvert.DeserializeObject(json, type);
        }

        public static object DeserializeText(this byte[] arrBytes) {
            return Encoding.Default.GetString(arrBytes);
        }
    }
}
