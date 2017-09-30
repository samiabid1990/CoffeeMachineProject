//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

//namespace WCFService.JsonConverter
//{
//    public abstract class JsonCreationConverter<T> : Newtonsoft.Json.JsonConverter
//    {
//        protected abstract T Create(Type objectType, JObject jsonObject);


//        public override bool CanConvert(Type objectType)
//        {
//            return typeof(T).IsAssignableFrom(objectType);
//        }


//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            var jsonObject = JObject.Load(reader);
//            var target = Create(objectType, jsonObject);
//            if (target != null) { serializer.Populate(jsonObject.CreateReader(), target); }
//            return target;
//        }

        
//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}