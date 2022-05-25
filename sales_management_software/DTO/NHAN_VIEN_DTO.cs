﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class NHAN_VIEN_DTO
	{
		private string _manv;
		public string manv
		{
			get { return _manv; }
			set { _manv = value; }
		}

		private string _matkhau;
		public string matkhau
		{
			get { return _matkhau; }
			set { _matkhau = value; }
		}

		private string _hotennv;
		public string hotennv
		{
			get { return _hotennv; }
			set { _hotennv = value; }
		}

		private int _dongia;
		public int dongia
		{
			get { return _dongia; }
			set { _dongia = value; }
		}

		private int _soluong;
		public int soluong
		{
			get { return _soluong; }
			set { _soluong = value; }
		}

		private string _maNCC;
		public string maNCC
		{
			get { return _maNCC; }
			set { _maNCC = value; }
		}

		private string _maloai;
		public string maloai
		{
			get { return _maloai; }
			set { _maloai = value; }
		}

		private string _sdt;
		public string sdt
		{
			get { return _sdt; }
			set { _sdt = value; }
		}

		private string _diachi;
		public string diachi
		{
			get { return _diachi; }
			set { _diachi = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public NHAN_VIEN_DTO(string manv_, string matkhau_, string hotennv_, int dongia_, int soluong_, string maNCC_, string maloai_, string sdt_, string diachi_, bool deleted_)
		{
			this.manv = manv_;
			this.matkhau = matkhau_;
			this.hotennv = hotennv_;
			this.dongia = dongia_;
			this.soluong = soluong_;
			this.maNCC = maNCC_;
			this.maloai = maloai_;
			this.sdt = sdt_;
			this.diachi = diachi_;
			this.deleted = deleted_;
		}
		public NHAN_VIEN_DTO()
        {

        }
	}
}