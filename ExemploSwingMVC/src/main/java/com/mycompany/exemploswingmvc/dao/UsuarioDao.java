    /*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.dao;

import com.mycompany.exemploswingmvc.model.Usuario;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class UsuarioDao {
    
    private Connection connection;
    
    public UsuarioDao(){
        this.connection = new ConnectionFactory().getConnection();
    }
    
    public void insert(Usuario usuario)
    {
        String strSql = "Insert into usuario (cpf, nome, idTipoUsuario) values ('" +
                usuario.getCpf() + "','" + usuario.getNome() + "'," + 
                usuario.getTipoUsuario(). getId() + ")";
        
        try {
            Statement stmt = connection.createStatement();
            stmt.execute(strSql);
            stmt.close();
        } catch (SQLException ex) {
            throw new RuntimeException(ex);
        }
    }
    
    public List<Usuario> findAll()
    {
        ArrayList<Usuario> usuarios = new ArrayList<> ();
        String strSql= "Select id, cpf, nome, idTipoUsuario from usuario";
        
        try{
            Statement stmt= connection.createStatement();
            ResultSet rs = stmt.executeQuery(strSql);
            
            while (rs.next()){
                Usuario usuario = new Usuario();
                usuario.setId(rs.getInt(1));
                usuario.setCpf(rs.getString(2));
                usuario.setNome(rs.getString(3));
                usuarios.add(usuario);
            }
            rs.close();
            stmt.close();
        } catch(SQLException ex) {
            throw new RuntimeException(ex);
        }
        return usuarios;
    }
}
