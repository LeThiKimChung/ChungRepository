﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace QLTQ
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the QLTQRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    [RepositoryFolder("42b9c0b9-78af-49f7-b3f1-82e36bc68e43")]
    public partial class QLTQRepository : RepoGenBaseFolder
    {
        static QLTQRepository instance = new QLTQRepository();
        QLTQRepositoryFolders.FrmLoginAppFolder _frmlogin;
        QLTQRepositoryFolders.FrmmainAppFolder _frmmain;
        QLTQRepositoryFolders.ThongBaoAppFolder _thongbao;
        QLTQRepositoryFolders.FrmLogin1AppFolder _frmlogin1;

        /// <summary>
        /// Gets the singleton class instance representing the QLTQRepository element repository.
        /// </summary>
        [RepositoryFolder("42b9c0b9-78af-49f7-b3f1-82e36bc68e43")]
        public static QLTQRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public QLTQRepository() 
            : base("QLTQRepository", "/", null, 0, false, "42b9c0b9-78af-49f7-b3f1-82e36bc68e43", ".\\RepositoryImages\\QLTQRepository42b9c0b9.rximgres")
        {
            _frmlogin = new QLTQRepositoryFolders.FrmLoginAppFolder(this);
            _frmmain = new QLTQRepositoryFolders.FrmmainAppFolder(this);
            _thongbao = new QLTQRepositoryFolders.ThongBaoAppFolder(this);
            _frmlogin1 = new QLTQRepositoryFolders.FrmLogin1AppFolder(this);
        }

#region Variables

        string _MaXa = "";

        /// <summary>
        /// Gets or sets the value of variable MaXa.
        /// </summary>
        [TestVariable("16fb601e-8ad1-4090-8211-3801f3bc1f84")]
        public string MaXa
        {
            get { return _MaXa; }
            set { _MaXa = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("42b9c0b9-78af-49f7-b3f1-82e36bc68e43")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmLogin folder.
        /// </summary>
        [RepositoryFolder("b9dbb0db-b244-41ec-9775-69003adf8f38")]
        public virtual QLTQRepositoryFolders.FrmLoginAppFolder FrmLogin
        {
            get { return _frmlogin; }
        }

        /// <summary>
        /// The Frmmain folder.
        /// </summary>
        [RepositoryFolder("80800de4-78f2-45e1-a8f0-f16ce07f3c6f")]
        public virtual QLTQRepositoryFolders.FrmmainAppFolder Frmmain
        {
            get { return _frmmain; }
        }

        /// <summary>
        /// The ThongBao folder.
        /// </summary>
        [RepositoryFolder("1224d4df-9a2f-418d-9eb1-6275708ae7a7")]
        public virtual QLTQRepositoryFolders.ThongBaoAppFolder ThongBao
        {
            get { return _thongbao; }
        }

        /// <summary>
        /// The FrmLogin1 folder.
        /// </summary>
        [RepositoryFolder("84cb7adc-8321-451c-9c0d-e8b1832eaf1a")]
        public virtual QLTQRepositoryFolders.FrmLogin1AppFolder FrmLogin1
        {
            get { return _frmlogin1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    public partial class QLTQRepositoryFolders
    {
        /// <summary>
        /// The FrmLoginAppFolder folder.
        /// </summary>
        [RepositoryFolder("b9dbb0db-b244-41ec-9775-69003adf8f38")]
        public partial class FrmLoginAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _đăngnhậpInfo;
            RepoItemInfo _thoatInfo;

            /// <summary>
            /// Creates a new FrmLogin  folder.
            /// </summary>
            public FrmLoginAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmLogin", "/form[@title='FrmLogin' and @processname='Quanlytuyenquan' and @controltypename='FrmLogin' and @instance='1']", parentFolder, 30000, null, true, "b9dbb0db-b244-41ec-9775-69003adf8f38", "")
            {
                _đăngnhậpInfo = new RepoItemInfo(this, "ĐăngNhập", ".//element[@controlname='btdangnhap']/button[@accessiblename='Đăng nhập']", 30000, null, "3f3cb6ff-e82c-4b5a-9f6d-d66e42bc5e77");
                _thoatInfo = new RepoItemInfo(this, "Thoat", ".//element[@controlname='btthoat']/button[@accessiblename='Thoát']", 30000, null, "e8539a00-fa76-456d-8966-628cac4c7852");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b9dbb0db-b244-41ec-9775-69003adf8f38")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b9dbb0db-b244-41ec-9775-69003adf8f38")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ĐăngNhập item.
            /// </summary>
            [RepositoryItem("3f3cb6ff-e82c-4b5a-9f6d-d66e42bc5e77")]
            public virtual Ranorex.Button ĐăngNhập
            {
                get
                {
                    return _đăngnhậpInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ĐăngNhập item info.
            /// </summary>
            [RepositoryItemInfo("3f3cb6ff-e82c-4b5a-9f6d-d66e42bc5e77")]
            public virtual RepoItemInfo ĐăngNhậpInfo
            {
                get
                {
                    return _đăngnhậpInfo;
                }
            }

            /// <summary>
            /// The Thoat item.
            /// </summary>
            [RepositoryItem("e8539a00-fa76-456d-8966-628cac4c7852")]
            public virtual Ranorex.Button Thoat
            {
                get
                {
                    return _thoatInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Thoat item info.
            /// </summary>
            [RepositoryItemInfo("e8539a00-fa76-456d-8966-628cac4c7852")]
            public virtual RepoItemInfo ThoatInfo
            {
                get
                {
                    return _thoatInfo;
                }
            }
        }

        /// <summary>
        /// The FrmmainAppFolder folder.
        /// </summary>
        [RepositoryFolder("80800de4-78f2-45e1-a8f0-f16ce07f3c6f")]
        public partial class FrmmainAppFolder : RepoGenBaseFolder
        {
            QLTQRepositoryFolders.PnChuaFolder _pnchua;
            RepoItemInfo _cậpnhậtdanhmụcInfo;
            RepoItemInfo _xaphuongInfo;
            RepoItemInfo _maxaInfo;
            RepoItemInfo _themInfo;
            RepoItemInfo _noneInfo;

            /// <summary>
            /// Creates a new Frmmain  folder.
            /// </summary>
            public FrmmainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Frmmain", "/form[@controlname='frmmain']", parentFolder, 30000, null, true, "80800de4-78f2-45e1-a8f0-f16ce07f3c6f", "")
            {
                _pnchua = new QLTQRepositoryFolders.PnChuaFolder(this);
                _cậpnhậtdanhmụcInfo = new RepoItemInfo(this, "CậpNhậtDanhMục", "container[@controlname='ribbonControl1']/container[@controlname='ഭ']//button[@accessiblename='Cập nhật danh mục']", 30000, null, "d136a0bc-53c8-4aa1-9f67-133146a4a929");
                _xaphuongInfo = new RepoItemInfo(this, "XaPhuong", "container[@controlname='ribbonControl1']/?/?/container[@controlname='ribbonBar2']/element/button[1]", 30000, null, "81e84ef9-7049-4b91-9a00-91a9e1de04a0");
                _maxaInfo = new RepoItemInfo(this, "MaXa", "container[@controlname='pnChua']//container[@controlname='pntren']/container[@controlname='groupPanel5']/text[@controlname='txt_maxaphuong']/text[@accessiblerole='Text']", 30000, null, "6b6c8066-7d48-43c3-9f65-fb2bc7a739dc");
                _themInfo = new RepoItemInfo(this, "Them", "container[@controlname='pnChua']//container[@controlname='pntren']/container[@controlname='groupPanel6']/?/?/button[@accessiblename='Thêm']", 30000, null, "e51dca11-6e5b-4992-ba53-0e59e582df6d");
                _noneInfo = new RepoItemInfo(this, "None", "container[@controlname='ribbonControl1']/container[@controlname='ഭ']//element[@accessiblename='']", 30000, null, "60661c8c-343c-411e-94c2-6c368003bed9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("80800de4-78f2-45e1-a8f0-f16ce07f3c6f")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("80800de4-78f2-45e1-a8f0-f16ce07f3c6f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CậpNhậtDanhMục item.
            /// </summary>
            [RepositoryItem("d136a0bc-53c8-4aa1-9f67-133146a4a929")]
            public virtual Ranorex.Button CậpNhậtDanhMục
            {
                get
                {
                    return _cậpnhậtdanhmụcInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The CậpNhậtDanhMục item info.
            /// </summary>
            [RepositoryItemInfo("d136a0bc-53c8-4aa1-9f67-133146a4a929")]
            public virtual RepoItemInfo CậpNhậtDanhMụcInfo
            {
                get
                {
                    return _cậpnhậtdanhmụcInfo;
                }
            }

            /// <summary>
            /// The XaPhuong item.
            /// </summary>
            [RepositoryItem("81e84ef9-7049-4b91-9a00-91a9e1de04a0")]
            public virtual Ranorex.Button XaPhuong
            {
                get
                {
                    return _xaphuongInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The XaPhuong item info.
            /// </summary>
            [RepositoryItemInfo("81e84ef9-7049-4b91-9a00-91a9e1de04a0")]
            public virtual RepoItemInfo XaPhuongInfo
            {
                get
                {
                    return _xaphuongInfo;
                }
            }

            /// <summary>
            /// The MaXa item.
            /// </summary>
            [RepositoryItem("6b6c8066-7d48-43c3-9f65-fb2bc7a739dc")]
            public virtual Ranorex.Text MaXa
            {
                get
                {
                    return _maxaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MaXa item info.
            /// </summary>
            [RepositoryItemInfo("6b6c8066-7d48-43c3-9f65-fb2bc7a739dc")]
            public virtual RepoItemInfo MaXaInfo
            {
                get
                {
                    return _maxaInfo;
                }
            }

            /// <summary>
            /// The Them item.
            /// </summary>
            [RepositoryItem("e51dca11-6e5b-4992-ba53-0e59e582df6d")]
            public virtual Ranorex.Button Them
            {
                get
                {
                    return _themInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Them item info.
            /// </summary>
            [RepositoryItemInfo("e51dca11-6e5b-4992-ba53-0e59e582df6d")]
            public virtual RepoItemInfo ThemInfo
            {
                get
                {
                    return _themInfo;
                }
            }

            /// <summary>
            /// The None item.
            /// </summary>
            [RepositoryItem("60661c8c-343c-411e-94c2-6c368003bed9")]
            public virtual Ranorex.Unknown None
            {
                get
                {
                    return _noneInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The None item info.
            /// </summary>
            [RepositoryItemInfo("60661c8c-343c-411e-94c2-6c368003bed9")]
            public virtual RepoItemInfo NoneInfo
            {
                get
                {
                    return _noneInfo;
                }
            }

            /// <summary>
            /// The PnChua folder.
            /// </summary>
            [RepositoryFolder("e76b34c5-02cd-461a-9db5-c347c4cb1678")]
            public virtual QLTQRepositoryFolders.PnChuaFolder PnChua
            {
                get { return _pnchua; }
            }
        }

        /// <summary>
        /// The PnChuaFolder folder.
        /// </summary>
        [RepositoryFolder("e76b34c5-02cd-461a-9db5-c347c4cb1678")]
        public partial class PnChuaFolder : RepoGenBaseFolder
        {
            RepoItemInfo _maxaphuongInfo;
            RepoItemInfo _buttonxoaInfo;

            /// <summary>
            /// Creates a new PnChua  folder.
            /// </summary>
            public PnChuaFolder(RepoGenBaseFolder parentFolder) :
                    base("PnChua", "container[@controlname='pnChua']", parentFolder, 30000, null, false, "e76b34c5-02cd-461a-9db5-c347c4cb1678", "")
            {
                _maxaphuongInfo = new RepoItemInfo(this, "MaXaPhuong", ".//container[@controlname='groupPanel4']/table[@controlname='dv_xaphuong']/row/cell[@accessiblevalue=$MaXa]", 30000, null, "4fdc3a4a-4099-44eb-a67d-9d87086ce76c");
                _buttonxoaInfo = new RepoItemInfo(this, "ButtonXoa", ".//container[@controlname='pntren']/container[@controlname='groupPanel6']/?/?/button[@accessiblename='Xóa']", 30000, null, "e06dfe79-a6f1-4e57-9173-dd68cad1c6e5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e76b34c5-02cd-461a-9db5-c347c4cb1678")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e76b34c5-02cd-461a-9db5-c347c4cb1678")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MaXaPhuong item.
            /// </summary>
            [RepositoryItem("4fdc3a4a-4099-44eb-a67d-9d87086ce76c")]
            public virtual Ranorex.Cell MaXaPhuong
            {
                get
                {
                    return _maxaphuongInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The MaXaPhuong item info.
            /// </summary>
            [RepositoryItemInfo("4fdc3a4a-4099-44eb-a67d-9d87086ce76c")]
            public virtual RepoItemInfo MaXaPhuongInfo
            {
                get
                {
                    return _maxaphuongInfo;
                }
            }

            /// <summary>
            /// The ButtonXoa item.
            /// </summary>
            [RepositoryItem("e06dfe79-a6f1-4e57-9173-dd68cad1c6e5")]
            public virtual Ranorex.Button ButtonXoa
            {
                get
                {
                    return _buttonxoaInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonXoa item info.
            /// </summary>
            [RepositoryItemInfo("e06dfe79-a6f1-4e57-9173-dd68cad1c6e5")]
            public virtual RepoItemInfo ButtonXoaInfo
            {
                get
                {
                    return _buttonxoaInfo;
                }
            }
        }

        /// <summary>
        /// The ThongBaoAppFolder folder.
        /// </summary>
        [RepositoryFolder("1224d4df-9a2f-418d-9eb1-6275708ae7a7")]
        public partial class ThongBaoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _megInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new ThongBao  folder.
            /// </summary>
            public ThongBaoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ThongBao", "/form[@title='Thông báo']", parentFolder, 30000, null, true, "1224d4df-9a2f-418d-9eb1-6275708ae7a7", "")
            {
                _megInfo = new RepoItemInfo(this, "Meg", "text[@controlid='65535']", 30000, null, "439702f7-d2bf-4269-a05d-b7b035ab44d5");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='OK']", 30000, null, "9a5d06ef-5c5e-4eee-b5b0-bb28860a0b58");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1224d4df-9a2f-418d-9eb1-6275708ae7a7")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1224d4df-9a2f-418d-9eb1-6275708ae7a7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Meg item.
            /// </summary>
            [RepositoryItem("439702f7-d2bf-4269-a05d-b7b035ab44d5")]
            public virtual Ranorex.Text Meg
            {
                get
                {
                    return _megInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Meg item info.
            /// </summary>
            [RepositoryItemInfo("439702f7-d2bf-4269-a05d-b7b035ab44d5")]
            public virtual RepoItemInfo MegInfo
            {
                get
                {
                    return _megInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("9a5d06ef-5c5e-4eee-b5b0-bb28860a0b58")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("9a5d06ef-5c5e-4eee-b5b0-bb28860a0b58")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The FrmLogin1AppFolder folder.
        /// </summary>
        [RepositoryFolder("84cb7adc-8321-451c-9c0d-e8b1832eaf1a")]
        public partial class FrmLogin1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _đăngnhậpInfo;
            RepoItemInfo _tendangnhapInfo;
            RepoItemInfo _matkhauInfo;

            /// <summary>
            /// Creates a new FrmLogin1  folder.
            /// </summary>
            public FrmLogin1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmLogin1", "/form[@controlname='FrmLogin']", parentFolder, 30000, null, true, "84cb7adc-8321-451c-9c0d-e8b1832eaf1a", "")
            {
                _đăngnhậpInfo = new RepoItemInfo(this, "ĐăngNhập", ".//element[@controlname='btdangnhap']/button[@accessiblename='Đăng nhập']", 30000, null, "ffe4e693-6091-46a7-aee1-4d30f9c4e4d3");
                _tendangnhapInfo = new RepoItemInfo(this, "TenDangNhap", ".//text[@controlname='txttendangnhap']/text[@accessiblerole='Text']", 30000, null, "3bca6bfd-7826-4e96-aba9-012c025acaca");
                _matkhauInfo = new RepoItemInfo(this, "MatKhau", ".//text[@controlname='txtmatkhau']/text[@accessiblerole='Text']", 30000, null, "909c5ead-3351-4fba-becb-2edf5941dada");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("84cb7adc-8321-451c-9c0d-e8b1832eaf1a")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("84cb7adc-8321-451c-9c0d-e8b1832eaf1a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ĐăngNhập item.
            /// </summary>
            [RepositoryItem("ffe4e693-6091-46a7-aee1-4d30f9c4e4d3")]
            public virtual Ranorex.Button ĐăngNhập
            {
                get
                {
                    return _đăngnhậpInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ĐăngNhập item info.
            /// </summary>
            [RepositoryItemInfo("ffe4e693-6091-46a7-aee1-4d30f9c4e4d3")]
            public virtual RepoItemInfo ĐăngNhậpInfo
            {
                get
                {
                    return _đăngnhậpInfo;
                }
            }

            /// <summary>
            /// The TenDangNhap item.
            /// </summary>
            [RepositoryItem("3bca6bfd-7826-4e96-aba9-012c025acaca")]
            public virtual Ranorex.Text TenDangNhap
            {
                get
                {
                    return _tendangnhapInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TenDangNhap item info.
            /// </summary>
            [RepositoryItemInfo("3bca6bfd-7826-4e96-aba9-012c025acaca")]
            public virtual RepoItemInfo TenDangNhapInfo
            {
                get
                {
                    return _tendangnhapInfo;
                }
            }

            /// <summary>
            /// The MatKhau item.
            /// </summary>
            [RepositoryItem("909c5ead-3351-4fba-becb-2edf5941dada")]
            public virtual Ranorex.Text MatKhau
            {
                get
                {
                    return _matkhauInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MatKhau item info.
            /// </summary>
            [RepositoryItemInfo("909c5ead-3351-4fba-becb-2edf5941dada")]
            public virtual RepoItemInfo MatKhauInfo
            {
                get
                {
                    return _matkhauInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}