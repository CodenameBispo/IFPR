/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.controller;

import com.mycompany.exemploswingmvc.model.TipoUsuario;
import java.util.ArrayList;
import java.util.List;

public class TipoUsuarioController {
    
    private List<TipoUsuario> tiposUsuario;
    
    public TipoUsuarioController() {
        tiposUsuario = new ArrayList<TipoUsuario>();
        TipoUsuario tipoAdm = new TipoUsuario();
        tipoAdm.setId(1);
        tipoAdm.setDescricao("Administrador");
        TipoUsuario tipoFunc = new TipoUsuario();
        tipoFunc.setId(2);
        tipoFunc.setDescricao("Funcionário");
        tiposUsuario.add(tipoAdm);
        tiposUsuario.add(tipoFunc);
    }
    
    public List<TipoUsuario> findAll() {
        return tiposUsuario;
    }    
}
