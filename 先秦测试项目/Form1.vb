Public Class Main
    Dim u As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim generator As New Random
        Dim i As Integer
        Dim j As String
        i = generator.Next(0, 149)
        u = i
        j = i.ToString
        PictureBox.Image = My.Resources._pic(j)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim list() As String = {"丁", "七", "万", "三", "上", "下", "不", "丘", "中", "为", "乃", "之", "乎", "乙", "习", "于", "云", "五", "井", "京", "人", "仓", "以", "保", "儿", "元", "先", "光", "入", "八", "六", "其", "出", "刀", "力", "勿", "化", "北", "十", "南", "卜", "占", "又", "及", "取", "口", "古", "可", "各", "合", "同", "启", "商", "四", "因", "土", "在", "夕", "大", "天", "央", "如", "子", "学", "安", "宋", "家", "小", "山", "岳", "工", "己", "帝", "年", "弓", "引", "心", "必", "戈", "成", "户", "才", "文", "斗", "旦", "明", "曰", "曲", "更", "月", "木", "未", "朱", "来", "林", "母", "比", "民", "水", "汝", "火", "父", "牛", "物", "猪", "王", "生", "田", "由", "甲", "男", "白", "百", "皿", "目", "矢", "石", "示", "禾", "立", "米", "系", "网", "羊", "羽", "而", "耳", "肉", "自", "舌", "虫", "蛇", "衣", "西", "见", "言", "车", "采", "长", "门", "雨", "面", "风", "马", "高", "鸟", "鸡", "鹿", "黄", "龙"}
        Label2.Text = list(u)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = "秦"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = "晋"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.Text = "燕"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Text = "郑"
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Label8.Text = "蔡"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label9.Text = "陈"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label10.Text = "宋"
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Label11.Text = "鲁"
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label12.Text = "齐"
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label13.Text = "蜀"
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Label14.Text = "巴"
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Label15.Text = "楚"
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Label16.Text = "吴"
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Label17.Text = "越"
    End Sub
End Class
