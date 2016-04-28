CREATE DATABASE Questions
GO
USE Questions
CREATE TABLE Questions (id int IDENTITY(1,1), Text nvarchar(255), Answer1 nvarchar(200), Answer2 nvarchar(200), Answer3 nvarchar(200),
						Answer4 nvarchar(200) PRIMARY KEY(id))
GO
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ���������� ����� �� ������, ��� ������� ������?', '�������', '��������', '��������', '��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ������� ������ �������� �������-�������� �������������� �������� ������?', '�������� ����', '�������� ����', '��������� ��������', '������� ������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� �� ���� ������� ����� ���������?', '����', '�����', '������', '���-���������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ����� ����� ���� �������� ������� ��������?', '�������', '���������', '������', '���������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ����� �������� �������� ����� ��������?', '����','����','���','������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('������ ������ ��������� �������� "������� ������"?','������ I', '��������� I', '����� I', '������ I');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� � ������ ���������� ���������� ���������, ��������� ���������� ������� ����?', '��������', '��������', '�����������', '�������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ������� ��������� ������ � ����������� ������ ����� ������?', '������ "������� ������"', '������ "�� ������"', '����� ��������', '����� ��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('� ����� ������ ������� ��������� ������ ������?', '���������', '������', '�����', '����');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ���� ���� ������ ������� �� ������� "������ ������"?', '�������', '�������','���','������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ���������� ��������� ����������� ������?', '�������', '����','�����', '��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ������ �������� ������� ������� �� ������������ ����?', '��������', '���������', '�������', '���������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ������� ����� ������ �� �������� ��������?', '������ ����', '������� �����', '���� �������','������ � �������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� �������� �������� �������?', '������', '�������', '���������', '���� ������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('�������� ������ �� ������������� ���������� ���������� ���������� ���������?', '�������', '�������', '���������', '�������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('� ����� ��������� ������ ��������� ����� ������� � ���� ���������?', '�������', '������', '��������', '��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� �� ���� ������� ������� �� ���������?', '"������������ ����"', '"������"', '"�� ��� ������ �������"', '"������� � ������"');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('� ����� ���� ������ ����������� ������� �����������?', '������', '����','������� ����','����� �� ���');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ���������� ����, �������������� �� ��������� �������������� ������ � ��������?', '���������', '�����������', '��������', '���������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ����� ������� ������ �������, �������� ����� �����-������?', '��������', '������', '�����','����');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ���� ���������� ��� �������� ������ � ��������?', '����������', '����������', '�������', '�������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� �������� � ������ ��������� ���������� ���������� �����������?', '����', '�������', '����������', '����� �����');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� �� ������� ���������, �� ��������, ��� � �����?', '������', '��������', '������', '������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� �� ���� ��������� ������� �.���������� ������ ���� �����?', '�����', '��������', '������� ������', '�������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ����� ������� �.��������� ������� �� ����� � ����� �� ��� �����?', '�����', '��������', '���������', '������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('���� ����������� ������ - �����������: "�������� ���, ������ ������ ���, ����� ����� ������ ������..."?', '���������', '������','�����������','��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('��� ���������� ������������� ������� ������� ������� � ��������������?', '��������','������','����','��������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ������� ��������� ����� �������� ��������?', '�������', '�������� �������', '���������', '����� �������');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('����� ������ ����������� ������� ���� ��������?', '�����', '������', '��������', '������');