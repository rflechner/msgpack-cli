﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_EnumInt64FlagsSerializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumInt64Flags> {
        
        public MsgPack_Serialization_EnumInt64FlagsSerializer(MsgPack.Serialization.SerializationContext context) : 
                this(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        public MsgPack_Serialization_EnumInt64FlagsSerializer(MsgPack.Serialization.SerializationContext context, MsgPack.Serialization.EnumSerializationMethod enumSerializationMethod) : 
                base(context, enumSerializationMethod) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumInt64Flags enumValue) {
            packer.Pack(((long)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumInt64Flags UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumInt64Flags)(messagePackObject.AsInt64()));
        }
    }
}