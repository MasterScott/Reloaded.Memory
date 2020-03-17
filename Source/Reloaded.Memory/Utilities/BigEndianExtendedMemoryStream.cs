﻿

using System.IO;
using System.Runtime.CompilerServices;

namespace Reloaded.Memory.Utilities
{
    public partial class ExtendedMemoryStream
    {
        
		/// <summary>
        /// Appends a Big Endian byte onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(byte structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian byte(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(byte[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian sbyte onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(sbyte structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian sbyte(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(sbyte[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian short onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(short structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian short(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(short[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian ushort onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(ushort structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian ushort(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(ushort[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian int onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(int structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian int(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(int[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian uint onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(uint structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian uint(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(uint[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian long onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(long structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian long(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(long[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
        
		/// <summary>
        /// Appends a Big Endian ulong onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(ulong structure)
        {
            structure = Endian.Reverse(structure);
            Write(Struct.GetBytes(structure));
        }

		/// <summary>
        /// Appends an array of Big Endian ulong(s) onto the <see cref="MemoryStream"/> and advances the position.
        /// </summary>
        public void WriteBigEndianPrimitive(ulong[] structures)
        {
			foreach (var structure in structures) 
				WriteBigEndianPrimitive(structure);
        }
    }
}
