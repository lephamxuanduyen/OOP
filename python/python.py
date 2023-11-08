class SinhVien:
    def __init__(self, MaSV, name, d1, d2):
        self.MaSV = MaSV
        self.HoTen = name
        self.Diem1= d1
        self.Diem2= d2
        self.DiemTB = None
        self.next = None

    def InSinhVien(self):
        print('Hello', self.MaSV,self.HoTen,  self.Diem1,self.Diem2, self.DiemTB)

    def TinhDiemTB(self):
        if (self.Diem1 is not None) and (self.Diem2 is not None):
            self.DiemTB= (self.Diem1+ self.Diem2)/2
        else:
            print('Chua co diem, nen chua tinh duoc trung binh')
        
    def CapNhatSV(self, hoten =None, d1=None, d2=None):
        if hoten is not None:
            self.HoTen = hoten
        if d1 is not None:
            self.Diem1= d1
        if d2 is not None: 
            self.Diem2= d2
#---------------------------------------------------------------------------
class DSSinhVien:
    def __init__(self):
        self.head = None
        self.last = None
    
    def InDSSinhVien(self):
        sv=self.head
        while sv is not None:
            sv.InSinhVien()
            sv=sv.next
    def  NhapDSSinhVien(self):  
        print('số SV cần nhập')
        n= int(input())
        for i in range(n):
            print('Vui long nhap thoong tin SV thu', i)
            print('Mã SV')
            maSV=input()
            print('Ho ten')
            name=input()
            print('Diem 1')
            d1=float(input())
            print('Diem 2')
            d2=float(input())
            newSV= SinhVien(maSV,name,d1,d2)
            newSV.InSinhVien()
            if self.head is None:
                self.head=newSV
            else:
                newSV.next=self.head
                self.head=newSV
    def TinhDiemTBSinhVien (self):
        sv=self.head
        while sv is not None:
            sv.TinhDiemTB()
            sv=sv.next
l=DSSinhVien()
l.NhapDSSinhVien()
l.InDSSinhVien()