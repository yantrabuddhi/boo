#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Tue Feb 10 16:03:09 2004
//
using System;

namespace Boo.Lang.Ast.Impl
{
	[Serializable]
	public abstract class TryStatementImpl : Statement
	{
		protected Block _protectedBlock;
		protected ExceptionHandlerCollection _exceptionHandlers;
		protected Block _successBlock;
		protected Block _ensureBlock;
		
		protected TryStatementImpl()
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 		}
		
		protected TryStatementImpl(Block successBlock, Block ensureBlock)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 			SuccessBlock = successBlock;
			EnsureBlock = ensureBlock;
		}
		
		protected TryStatementImpl(LexicalInfo lexicalInfo, Block successBlock, Block ensureBlock) : base(lexicalInfo)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 			SuccessBlock = successBlock;				
			EnsureBlock = ensureBlock;				
		}
		
		protected TryStatementImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.TryStatement;
			}
		}
		public Block ProtectedBlock
		{
			get
			{
				return _protectedBlock;
			}
			
			set
			{
				
				if (_protectedBlock != value)
				{
					_protectedBlock = value;
					if (null != _protectedBlock)
					{
						_protectedBlock.InitializeParent(this);
					}
				}
			}
		}
		public ExceptionHandlerCollection ExceptionHandlers
		{
			get
			{
				return _exceptionHandlers;
			}
			
			set
			{
				
				if (_exceptionHandlers != value)
				{
					_exceptionHandlers = value;
					if (null != _exceptionHandlers)
					{
						_exceptionHandlers.InitializeParent(this);
					}
				}
			}
		}
		public Block SuccessBlock
		{
			get
			{
				return _successBlock;
			}
			
			set
			{
				
				if (_successBlock != value)
				{
					_successBlock = value;
					if (null != _successBlock)
					{
						_successBlock.InitializeParent(this);
					}
				}
			}
		}
		public Block EnsureBlock
		{
			get
			{
				return _ensureBlock;
			}
			
			set
			{
				
				if (_ensureBlock != value)
				{
					_ensureBlock = value;
					if (null != _ensureBlock)
					{
						_ensureBlock.InitializeParent(this);
					}
				}
			}
		}
		new public TryStatement CloneNode()
		{
			return (TryStatement)Clone();
		}
		
		override public object Clone()
		{
			TryStatement clone = (TryStatement)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(GetType());
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			
			if (null != _protectedBlock)
			{
				clone._protectedBlock = (Block)_protectedBlock.Clone();
			}
			if (null != _exceptionHandlers)
			{
				clone._exceptionHandlers = (ExceptionHandlerCollection)_exceptionHandlers.Clone();
			}
			if (null != _successBlock)
			{
				clone._successBlock = (Block)_successBlock.Clone();
			}
			if (null != _ensureBlock)
			{
				clone._ensureBlock = (Block)_ensureBlock.Clone();
			}
			if (null != _modifier)
			{
				clone._modifier = (StatementModifier)_modifier.Clone();
			}
			
			return clone;
		}
		
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			
			if (_protectedBlock == existing)
			{
				this.ProtectedBlock = (Block)newNode;
				return true;
			}
			if (_exceptionHandlers != null)
			{
				ExceptionHandler item = existing as ExceptionHandler;
				if (null != item)
				{
					if (_exceptionHandlers.Replace(item, (ExceptionHandler)newNode))
					{
						return true;
					}
				}
			}
			if (_successBlock == existing)
			{
				this.SuccessBlock = (Block)newNode;
				return true;
			}
			if (_ensureBlock == existing)
			{
				this.EnsureBlock = (Block)newNode;
				return true;
			}
			if (_modifier == existing)
			{
				this.Modifier = (StatementModifier)newNode;
				return true;
			}
			return false;
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			TryStatement thisNode = (TryStatement)this;
			Statement resultingTypedNode = thisNode;
			transformer.OnTryStatement(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
